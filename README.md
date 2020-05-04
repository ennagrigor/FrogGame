# gamedev-week 06-Q3 making a core process of a game
Contains all the third question answers from lesson 5 homework + the phisical borders from Q2 (yellow circles): [gamedev-5780](https://github.com/erelsgl-at-ariel/gamedev-5780)

The purpose of the game is to get the player (the green cube) to the finish line.

**Created by:**

[Chen Ostrovski](https://github.com/ChenOst)

[Enna Grigor](https://github.com/ennagrigor)

<img src="https://github.com/ennagrigor/FrogGame/blob/master/Screenshot_1.png" width=400>

# objects in game:

## The player (frog):
The player has a Mover class that is responsible for functions of the player 
- `w` or `up key`- moves the player up. 
- `s` or `down key` - moves the player down.
- `a` or `left key` - moves the player left.
- `d` or `right key` - moves the player right.

The player has two main parameters:
- `_speed` - determines the players speed of movement.
- `_lives` - keeps score of the players lives (3 hits and the player goes back to the beginning).

The player also has four main functions:
- `void start()` - determines the first position the game starts with.
- `void update()` - keeps track of the player's movements and sets boundries so that the player stays in the borders of the game.
- `public void Damage()` - keeps track of lives and puts the player in first position if loses.
- `public void Win()` - Destroys the player object when the player won.

## Cars
The cars are objects that are made as prefabs. They move across the screen and contain EnemyMover class.
They contain a trigger that counts how many times the player collided with them (3 times and player loses).
Each object moves at diffent speed that is determend by the `_speed` value. 

The cars have two main functions:
- `void Update()` - Moves the cars across the screen and moves them back to the beginning when the pass the border.
- `private void OnTriggerEnter(Collider other)` - The trigger that keeps count of contact with the player and calls the Damage() function that the player has.

## Finish line

The finish line is an object that when the player colides with it - it finishes the game and gives the player an option to re-enter the game.
Crossing the line also triggers text that lets the player know they won and can play again by pressing "r".
The finish line has the parameter `_YouWonText`that can be edited in the editor and changed.

It also has Three main functions:
- ` void Start()` - Sets the win text to false and positions the endline.
- `void Update()` - Lets the player start the game again by pressing "R".
- `private void OnTriggerEnter(Collider other)` - A trigger that listens to when the player crossed the line and sets the _wintext to true and calls the "win()" function.

<img src="https://github.com/ennagrigor/FrogGame/blob/master/Screenshot_2.png" width=400>

## 5 Obsticles

The obsticles are objects that are also made as prefabs and make the game a little harder.
The player can't go through the obsticles and therefor they have to go around (phsical borders).

<img src="Images/q4.1.png" width=400> <img src="Images/q4.2.png" width=400>
