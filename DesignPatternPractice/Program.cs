using System;
using System.Collections.Generic;

namespace DesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStrategyPattern();
            TestObserverPattern();
            TestDecoratorPattern();
        }

        // When should we consider using decorator pattern?
        //  1. requires several different attributes to be applied to a base class and its children
        //  2. attributes are not dependent on the order they are applied (e.g., A->B and B->A give same result)
        //  3. attributes can be duplicated (e.g., adding extra shot to a cup of coffee can happen multiple times)
        //  4. some attributes might be added/deleted in the future
        // Note that 2 and 3 are just recommendations.
        // We probably can detect and control the order or stacking of decorators.
        // However, that would add extra layer of complexity (which we generally want to avoid)
        static void TestDecoratorPattern()
        {
            // Naive approach
            //
            // Pros:
            //  1. object creation is simple (single constructor is all you need)
            //  2. minimal # of classes, thus easy to understand
            //  3. can handle dependency between attributes
            //     (e.g., give visual effect for enemies with isPowerful and isResistant flags both set to true)
            //
            // Cons:
            //  1. adding/deleting attribute requires modification on all child classes
            //     (e.g., removing isResistant flag from Enemy requires removing corresponding parameter in all child class constructors)
            //  2. effect of each attribute is spread all over Enemy class,
            //     making it hard to track or analyze the overall effect independently (i.e., low cohesion)
            {
                var enemies = new List<Decorator.Naive.Enemy>()
                {
                    new Decorator.Naive.Archer(false, false, false), // Normal archer
                    new Decorator.Naive.Archer(false, true, true), // Elite powerful archer
                    new Decorator.Naive.Knight(false, false, false), // Normal knight
                    new Decorator.Naive.Knight(true, false, true) // Elite resistant knight
                };

                foreach(var enemy in enemies)
                {
                    Console.WriteLine($"{enemy.GetFullName()} - HP: {enemy.GetHP()}, ATK: {enemy.GetATK()}");
                    enemy.Attack();
                }

                PrintSeperatingLine();
            }

            // Better approach with decorator pattern
            //
            // Pros:
            //  1. adding/deleting attribute is simple (just delete corresponding class)
            //  2. all effects of one attribute is handled in single class (high cohesion)
            //  3. concrete classes of Enemy does not depend on attributes (loose coupling)
            //
            // Cons:
            //  1. object creation is lot more complex
            //  2. higher abstraction means increased complexity and effort required to understand the code
            //  3. cannot control or handle dependency between each attributes
            //     (e.g., we need to write more complex code in order to detect and prevent duplicate attributes
            //     being applied to an Archer instance, something like "Powerful Powerful Elite Powerful Archer")
            {
                var enemies = new List<Decorator.Better.Enemy>()
                {
                    new Decorator.Better.Archer(), // Normal archer
                    new Decorator.Better.Elite(new Decorator.Better.Powerful(new Decorator.Better.Archer())), // Elite powerful archer
                    new Decorator.Better.Knight(), // Normal Knight
                    new Decorator.Better.Elite(new Decorator.Better.Resistant(new Decorator.Better.Knight())), // Elite resistant knight
                };

                foreach (var enemy in enemies)
                {
                    Console.WriteLine($"{enemy.GetName()} - HP: {enemy.GetHP()}, ATK: {enemy.GetATK()}");
                    enemy.Attack();
                }

                PrintSeperatingLine();
            }
        }

        // When should we consider using observer pattern?
        //  1. when your program has event-event handler concept (e.g., do A, B, and C when event D occures)
        //  2. when you think more actions involving several classes are possibly added (e.g., perform logging whenever score changes)
        static void TestObserverPattern()
        {
            // Naive approach
            //
            // Pros:
            //  1. everything happens inside IncrementScore, allowing us to easily
            //     identify which things happen when we increment score.
            //
            // Cons:
            //  1. violates single responsibility principle.
            //     Note that IncrementScore does multiple jobs (e.g., playing sound, updating UI, ...) aside from handling core gameplay logics.
            //  2. violates open-closed principle (e.g., adding more visual effects on score change requires modification on BoardGame class)
            {
                var game = new Observer.Naive.BoardGame();
                game.IncrementScore(5);
                game.IncrementScore(10);
                game.IncrementScore(100);

                PrintSeperatingLine();
            }

            // Better approach with observer pattern
            //
            // Pros:
            //  1. loose coupling between BoardGame and other classes
            //  2. easy to add more tasks to perform when we increment score without modifying existing classes
            //     (e.g., create a ParticleEffect class that implements IObserver<int>, then add it as observer to BoardGame instance)
            //  3. facilitates obeying single responsibility principle.
            //
            // Cons:
            //  1. hard to track of all side effects related to a single event
            //     (e.g., we need to look at all AddObserver() calls in order to identify all possible listeners)
            //  2. requires cleanup whenever observer doesn't want/cannot listen anymore (e.g., the observer instance is destroyed)
            //  3. requires longer initialization code on user side (e.g., Program.cs in this case)
            {
                var game = new Observer.Better.BoardGame();
                var scoreUI = new Observer.Better.ScoreUI();
                var soundPlayer = new Observer.Better.SoundPlayer();

                game.AddObserver(scoreUI);
                game.AddObserver(soundPlayer);

                game.IncrementScore(5);
                game.IncrementScore(10);
                game.IncrementScore(100);

                game.RemoveObserver(scoreUI);
                game.RemoveObserver(soundPlayer);

                PrintSeperatingLine();
            }
        }

        // When should we consider using strategy pattern?
        //  1. there are several actions that fall into same group (e.g., attaking action <- swing hammer, fire a gun, ...)
        //  2. several classes share that action in common (e.g., three different robots with same walking mechanism)
        //  3. want to use combination of different actions from several groups (e.g., one movement, one attack, two player interaction, ...)
        static void TestStrategyPattern()
        {
            // Naive inheritance
            //
            // Pros:
            //  1. less # of classes
            //  2. straight forward and easy to understand
            //
            // Cons:
            //  1. code duplication (e.g., Console.WriteLine("Flying") on both FighterPlane and HammerPlane)
            //  2. multiple editing required to change single behavior
            //     (e.g., modifying "Flying" to "Flying to the target" would need modification on HammerPlane and FighterPlane)
            {
                var enemyList = new List<Strategy.Naive.IEnemy>
                {
                    new Strategy.Naive.FighterPlane(),
                    new Strategy.Naive.HammerRobot(),
                    new Strategy.Naive.HammerPlane()
                };

                foreach (var enemy in enemyList)
                {
                    enemy.Move();
                    enemy.Attack();
                }

                PrintSeperatingLine();
            }

            // Better approach with strategy pattern
            //
            // Pros:
            //  1. code reusability (e.g., FighterPlane and HammerPlane sharing same movement behavior)
            //  2. allows dynamic change in behavior (e.g., a transformer plane would need switching between Fly and Walk)
            //  3. easy to modify a specific behavior (e.g., modifying "Flying" to "Flying to the target" only requires modification on Fly class)
            //  4. easy to add more enemy types with different combination of strategy (e.g., a new walking robot that fires bullets)
            //
            // Cons:
            //  1. more classes and interfaces
            //  2. little bit harder to understand than naive inheritance
            {
                var enemyList = new List<Strategy.Better.Enemy>
                {
                    new Strategy.Better.FighterPlane(),
                    new Strategy.Better.HammerRobot(),
                    new Strategy.Better.HammerPlane()
                };

                foreach (var enemy in enemyList)
                {
                    enemy.Move();
                    enemy.Attack();
                }

                PrintSeperatingLine();
            }
        }

        static void PrintSeperatingLine()
        {
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
