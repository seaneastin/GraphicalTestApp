
| Sean Eastin|
| :---          	|
| s198013 (Student ID Number)      	|
| Math For Games |
| Two player Tank Game Documentation |

## I. Requirements(Here is where the application requirements are laid out)

1. Description of Problem(Here is where you layout what the purpose of the application. Address not only what the problem is the application is designed to solve, but the specifications of the problem)

	- **Name**: Two player Tank Game(Name of application)

	- **Problem Statement**(Description of problem.): 
	Creation of a game project using the C++ programming language and maintained within a Version Control repository, either from a brief provided by your teacher or via your own brief approved by your teacher

	- **Problem Specifications**(Requirements to solve the problem):  The game must include: ,graphical components, using a third-party library,a graphical User Interface,use of pre-made image assets,respond to Input devices

2. Input Information(All information being given to the application)
- Player 1's controls are wasd for movemnet and q and e for turret controls spacebar is used for fireing the turret.

- Player 2's controls are ijkl for movemnet and u and o for turret controls enter is used for fireing the turret.

3.  Output Information(All information output to the user) 
-The program displays different information and textures based on 4 different possible states the can game can be in:

   
4. User Interface Information(Here is where user interface information is explained ex: menu options or  a HUD )


## II. Design(This is where you document how your program works. The main game loop should be described here. Everything from the programs ending to its beginning should be documented here. You can use diagrams, gifs, or other images to help.)

1. _System Architecture_(This is where you describe how your application flows. This should break down the main game loop and how the application works from start to end)

| 
|:-----------

| ![User Interface gif]()
| 

|
|:------------

|![User Interface gif]()


|

|![User Interface gif]()

|
1. _User Interface_(This is where each UI element is explained. For example each menu option the player has should would be explained here.)


|![User Interface gif]()

|![User Interface gif]()
 

3. ### Object Information(All classes and their atrributes shsould be described here.)

   **File**: program.cs

     Description: where the program starts and sets up the game
     
    **Attributes



    **File**: Player 1.cs

     Description: player 1's tank this is exaxtly the same as player2.cs

     **Attributes
     
        name : _sprite
        Desription: the tanks sprite
        Type: Sprite
        Visablity: private


        name: hitbox
        Description: the tanks hitbox.
        Type: AABB
        Visabilaty: public

        name: turret
        description: the tanks turret
        Type: Turret
        Visability: private


        name: Player1
        Description: the constructor for the tank
        type: function



        Name: Drawdebugstuff
        Description: draws the players X and Y and the players hitbox location will not work on realease
        type: function



        Name: Moveup
        Description: the funcation for the player moveing up
        Tyoe: function

        Name: Movedown
        Description: the function for the player moveing down
        Tyoe: function

        Name: Rotateleft
        Description: rotates the player to the left
        type: function

        Name: Rotateleft
        Description: rotates the player to the left
        type: function

        Name: CollidewithTank
        Description: this was supposed to destroy the tank but is now unused although if you play with hitboxes showing it will still show collision with the other tank.
        type function

        Name: ScreenWrap
        Description: prevents the tank from leaveing the screen
        type: function

        Name: Destroy
        Description: destorys the player when called
        type: function


    **File**: Player 2.cs

     Description: player 2's tank this is exaxtly the same as player1.cs

     **Attributes
     
        name : _sprite
        Desription: the tanks sprite
        Type: Sprite
        Visablity: private


        name: hitbox
        Description: the tanks hitbox.
        Type: AABB
        Visabilaty: public

        name: turret
        description: the tanks turret
        Type: Turret
        Visability: private


        name: Player1
        Description: the constructor for the tank
        type: function



        Name: Drawdebugstuff
        Description: draws the players X and Y and the players hitbox location will not work on realease
        type: function



        Name: Moveup
        Description: the funcation for the player moveing up
        Tyoe: function

        Name: Movedown
        Description: the function for the player moveing down
        Tyoe: function

        Name: Rotateleft
        Description: rotates the player to the left
        type: function

        Name: Rotateleft
        Description: rotates the player to the left
        type: function

        Name: CollidewithTank
        Description: this was supposed to destroy the tank but is now unused although if you play with hitboxes showing it will still show collision with the other tank.
        type function

        Name: ScreenWrap
        Description: prevents the tank from leaveing the screen
        type: function

        Name: Destroy
        Description: destorys the player when called
        type: function





    **File**: turret.cs

     Description: the turret for both the tanks

     **Attributes
     
        Name: maxammo
        Description: the maximum amount of ammo the player can have
        Type: int

         Name: timer
         Description: the timer that is used when refilling ammo
         Type: Timer

         Name: ammo
         Description: the ammount of ammo the player has
         Type: int

         Name: tankturret
         Description: the sprite for the turret
         Type: Sprite

         Name: _playernumber
         Description: passed down from the tank used to determine the turrets controls
         type: Sprite

         Name: rotateleftcontrol
         Description: the control for rotateing left
         type: int

         Name: rotaterightcontrol
         Description:  the control for rotateing right
         type: int

         Name: firecontrol
         Description: the control for fireing the turret
         Type: int

         Name: bulletsprite
         Description: the sprite for the bullet
         Type: int


         Name: rotateleft
         Description: rotates the turret to the left
         Type: function

         
         Name: rotateRight
         Description: rotates the turret to the Right
         Type: function

         Name: Fire
         Description: fires a bullet
         Type: function

         Name: RestoreAmmo
         Description: restores the ammo of the player uses the timer set up earlier to do this.
    **File**:  Bullet.cs
    
    Description: the bullet the turret shoots this will detect collision with the player and destroy if it goes off screen

    **Atributes

        Name: hitbox
        Description: the hitbox for the bullet
        Type: AABB

        Name: sprite
        Description: the bullets sprite
        Type: Sprite

        Name: _playernumber
        Description: used to identify who shot the bullet so the bullet does not actually kill them
        Type: int

        Name: OnColide
        Description: if the bullet hits a tank it will check to make sure the player that it hit was not the one that fired it
        Type: function

        Name: Destroy
        Description: destroys the bullet this is called if the bullet goes offscreen
        Type: function

     **File**:  AABB.cs
    
    Description: this where collision detection is done and also makes hitboxes

    **Atributes

        Name: _color
        Description: this is the hitboxes color
        type: Color

        name: width
        Description:
        Type:

        Name Height
        Description:

        Name: Top
        Description: the top of the hitbox
        type: property

        Name: Bottom
        Description: the Bottom of the hitbox
        type: property

        Name: Left
        Description: the Left of the hitbox
        type: property

        Name: Right
        Description: the Right of the hitbox
        type: property


        Name: AABB
        Description: used to create a new instance of AABB
        Type: function

        Name: DetectColllision
        Description: detects if the hitbox hits another hitbox
        Type: function

        Name: Draw
        Description: Draws the hitbox on the screen
        Type: Function

     **File**:  Actor.cs
    
    Description: 

    **Atributes