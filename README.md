# The Bowling Game Saga: A Quest for Strikes and Spares 🎳

Greetings, noble Code Squires and seasoned Code Knights! 🛡️👩‍💻👨‍💻

Prepare yourselves for a grand adventure in the mystical realm of the Bowling Alley! The King of Pins has issued a royal decree: "Whosoever shall calculate the scores most accurately shall be rewarded with eternal glory and free nachos!"

## The Epic Rules of Bowling 📜

- **The Strike**: A strike is when you knock down all 10 pins with your first ball. Shout **"Strike!"** and do a victory dance. 🕺💃
  
- **The Spare**: A spare is when you knock down all remaining pins with your second ball. Yell **"Spare!"** and high-five the nearest person. 🙏

- **The Open Frame**: If you fail to knock down all 10 pins after two balls, it's called an open frame. Mutter **"Darn it!"** and try not to kick the ball return. 🤦‍♀️🤦‍♂️

- **The Tenth Frame**: The 10th frame is a special beast. You can roll up to three balls if you score a strike or a spare. It's like a bonus level, but with more nachos at stake. 🌮

## Your Legendary Mission 🚀

Your quest, should you dare to accept, is to write a spell (code, for the muggles) that calculates the score of a bowling game, considering strikes, spares, and the enigmatic 10th frame.

### Understanding the Game 🎳
The Bowling Game consists of 10 frames, where you try to knock down pins with up to two rolls per frame, aiming to achieve the highest score possible. (max score is 300)

### Starting Point 🚀
Your `Game` class should have the following main methods:

- `void roll(int pins)`: This method is called each time a ball is rolled and knocks down `pins` number of pins.
  
- `int Score()`: This method is called at the end of the game to calculate and return the total score.

**May your code be ever clean, and may your tests be ever green! 🌟**

Ready? Set? Bowl—err, Code! 🚀

## Bonus Mission: The Random Bowling Simulator 🎲🎳

Just when you thought you were ready to claim your free nachos, the Wizard of the Bowling Alley appears! 🧙‍♂️

"Ah, you've mastered the art of score calculation, but can you simulate the chaos of a real game?" he cackles.

### Your Bonus Quest 🌟

Your bonus mission, should you choose to accept, involves creating a random game simulator. This simulator will:

- Randomly generate rolls, taking care to not knock down more pins than are available.
  
- Output an ASCII table after the game, displaying the score per frame. Use `X` to represent a strike and `/` to represent a spare.

For example, the ASCII table might look something like this:

Frame: 1	2	3	4	5	6	7	8	9	10	Total

Rolls: 9/	X	2	6	X	X	X	6/	1	X	154


**Can you rise to the challenge and become the ultimate Bowling Game Master? 🏆**

Ready for more? Set? Code again! 🚀


## Hints (don't read this if you don't want spoilers) 📝

P

P

P

P

P

P

### Testing Hints 🧪
- Start by writing a test for the simplest case: a gutter game where no pins are knocked down.
  
- Move on to testing a game where one pin is knocked down with each roll.

- Now test a perfect game with 10 strikes.
  
- Once those are passing, you can proceed to test more complex scenarios like spares and strikes.

Remember, the key to solving this kata is incremental development and refactoring. Write a test, make it pass, and then refactor if necessary before moving on to the next test.
