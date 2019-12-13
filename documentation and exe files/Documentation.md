
| Sean Eastin|
| :---          	|
| s198013 (Student ID Number)      	|
| Math For Games |
| Two player Tank Game Documentation |

## I. Requirements(Here is where the application requirements are laid out)

1. Description of Problem(Here is where you layout what the purpose of the application. Address not only what the problem is the application is designed to solve, but the specifications of the problem)

	- **Name**: Two player Tank Game

	- **Problem Statement**: 
	Creation of a game using matrix3 and vector3 to maker a charecter move
	- **Problem Specifications**(Requirements to solve the problem):  The game uses raylib, a vector 3 and matrix 3 class and has to load images from

2. Input Information


- Player 1's controls are wasd for movemnet and q and e for turret controls spacebar is used for fireing the turret.

- Player 2's controls are ijkl for movemnet and u and o for turret controls enter is used for fireing the turret.

3.  Output Information(All information output to the user) 
-The program displays different information and textures based on 4 different possible states the can game can be in:

   
4. User Interface Information

the game displays the ammo for each player and displays each player on the screen


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
    
    Description: entity inherits from this class

    **Atributes

    Name: OnStart
    Description: anything added to this event will be called on start
    Type: StartEvent

    Name: OnUpdate
    Description: anything added to this event will be called on update.
    Type: UpdateEvent

    Name: OnDraw
    Description: anything added to this event will be called on draw
    Type: DrawEvent

    Name: Started
    Description: tells if the scene has started
    Type: Property

    Name Parent
    Description: returns or sets the entitity's parent
    Type: Actor

    Name: _children
    Description: 
    Type: List

    Name: _additions
    Description:
    Type: List

    Name: _removals
    Description:
    Type: List

    Name _localTransform
    Description: 
    Type: Property

    Name: _globalTransfrom
    Description:
    Type: Property

    Name: X
    Description: The X coordinate for the entity
    Type: property

    Name: XAbsolute
    Description: 
    Type: Property

    Name: Y
    Description: the Y coordinate for the entity
    Type: Property

    Name: YAbsolute
    Description: 
    Type: property

    Name: GetRotation
    Description: gets the rotation for the entity
    Type: Function

    Name: Rotate
    Description: rotates the entity by a certiatn number
    Type: Function
    Pararmeters: float radians

    Name: GetScale
    Description: is supposed to get the scale of an entity but it only returns 1 due to not being implemented
    Type: function

    Name: AddChild
    Description: adds the enitiy entered in as a parameter as a child of the parent
    Type: function
    parameters: actor child

    Name: RemoveChild
    Description: removes the entity from being a child of the parent
    Type: function
    parameters: actor child

    Name: UpdateTransform
    Description: updates the transform of all entitys
    Type: function

    Name: Start
    Description: called when the scene is started
    Type: function

    Name: Update
    Description: is called to update all the entites and calles the update event
    Type: function

    Name: Draw
    Description: is called to update and invoke ondraw event
    Type: function

    Name: Getm11
    Description: gets m11 from matrix3
    Type: property

    Name: Getm12
    Description: gets m12 from matrix3
    Type: property


   **File**:  Entity.cs
    
    Description: all entitys inherit from this class

        **Atributes

        Name: _velocity
        Description: velocity is used in a formula that makes the entity move
        Type: Vector3

        Name: _acceleration
        Description: acceleration is used in a formula that makes the entity move
        Type: Vector3

        Name: XVelocity
        Description: returns _velocity.x so other classes can use it
        Type: property

        Name: XAcceleration
        Description: returns _acceleration.x so other classes can use it
        Type: property

        Name: YVelocity
        Description: returns _veloicity.y so other classes can use it
        Type: property

        Name: YAcceleration
        Description: returns _acceleration.y so other classes can use it
        Type: property

        Name: Entity
        Description constructer that makes an entity
        Type: function
        Parameters: float x, float y

        Name: Update
        Description: the entity's update
        Type: function
        Parameters: float deltatime

      **File**:  Entity.cs
    
    Description: all entitys inherit from this class

   **Atributes

         Name: gameWidth
         Description: the games width used in a function that prevents things from going offscreen
         Type: int

         Name: gameHeight
         Description: the games height used in a function that prevents things from going offscreen
         Type: int

         Name: _root
         Description:
         Type: Actor

         Name: _next
         Description:
         Type: Actor

         Name: _gameTimer
         Description: the games timer this is used so everything goes at the same speed no mattter the fps
         Type: Timer

         Name: Game
         Description: the games constructor it takes the games width and height so other functions that need it can use it .
         Type: Function
         Parameters: int width, int height, string title

         Name: Run
         Description: called when the game runs
         type: function

         Name: Root
         Description: 
         Type: function

      **File**:  Input.cs
    
    Description: this class handles all the input

   **Atributes
         
         Name: IsKeyPressed
         Description: returns if the key specified is pressed
         Type: Function
         paremeters: int key

         Name: IsKeyDown
         Description: returns if the key specified is down
         Type: Function
         paremeters: int key

         Name: IsKeyRealeased
         Description: returns if the key is released.
         Type:Function
         paremeters: int key

         Name: IsKeyUp
         Description: returns if the key is not pressed
         Type: function
         Parameters: int key

      **File**:  Sprite.cs
    
    Description: the entitys sprite

   **Atributes

         Name: _texture
         Description: used for loading the sprite
      Type: Texture2D

         Name: _image
       Description: used for loading the image from a file
         Type: Image

         Name: Width
         Description: returns the the textures width
         Type: property

         Name: Height
         Description: returns the textures height
         Type: property

         Name: Sprite
         Description: the constructor for the sprite.
         Type: function
         Parameters: string path

         Name: Draw
         Description: the sprites draw function
         Type: function

      **File**:  Timer.cs
    
    Description: this makes sure that no matter what fps you have everything moves at the same speed

   **Atributes

         Name: _stopwatch
         Description: a timer that is used in this class
         Type: Stopwatch

         Name: _currentTime
         Description:  the current time is used to get delta time
         Type: long

         Name: _previousTime
         Description: the previous time this is used to get delta time
         Type: long

         Name: _deltaTime
         Description: delta time is used when we need to get delta time
         Type: float

         Name: Timer
         Description: starts the stopwatch
         Type: Function

         Name: Restart
         Description: restarts the stopwatch
         Type: function

         Name: Seconds
         Description: returns seconds
         Type: function

         Name: GetDeltaTime
         Description: gets deltatime using a formula
         Type: function



      **File**:  Vector3.cs
    
    Description: the enttites x, y, z

   **Atributes

         Name: x
         Description: the x of an entity
         Type: float

         Name: y
         Description: the y of an entity
         Type: float

         Name: z
         Description: the z of an entity
         Type: float

         Name: Vector3
         Description: a default constructor for vector3
         Type: function

         Name: Vector3
         Description: the constructor for vector3
         Type: function

         Name: ToString
         Description: is supposed to display the coordinates of an entity
         Type: function

         Name: Vector3 + Vector3
         Description: an operator that allows you to add vector3s
         Type: operator
         parameters: Vecotr3 lhs, Vector3 rhs

         Name: Vector3 - Vector3
         Description: allows you to subtract vector3 from a vector3
         Type: Operatro
         Parameters: Vector3 lhs, Vector3 rhs

         Name: Vector3 / number
         Description: allows you to divide a vector3 and a number
         Type: operator
         Parameters: Vector3 lhs, float number

         Name: number / Vector3
         Description: allows you to divide a vector3 and a number
         Type: operator
         Parameters: float number, Vector3 rhs

         Name: number * Vector3
         Description: allows you to multiply a float and a vector3
         Type: Operator
         Parameters: float number, vector3 rhs

         Name: Vector3 * number
         Description: allows you to multiply a number and a vector3
         TYpe: Operator
         Parameters: Vector3 lhs, float number 


      **File**:  Matrix3.cs
    
    Description: the enttites x, y, z

   **Atributes
         
         Name: m11, m12, m13, m21,m22,m23, m31,m32,m33
         Description: the matrix values are stored here
         Type: float


         Name: To String
         Descritption: prints out the matrix values
         Type: function

         Name: set
         Description: sets the matrix3 values
         Type: function
         Parameters: float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33

         Name: Matrix3
         Descriiption: the default contructor for matrix3
         Type: function

         Name: Matrix3
         Description: the contructor for matrix3
         Type: function
         Parameters: float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33

         Name: *
         Descrition: mulitplying a matrix3 times a Matrix3
         Type: Operator
         Parameters: Matrix3 lhs, Matrix3 rhs


         Name: *
         Description: multiplying a matrix3 times a vector3
         Type: operator
         Parameters: Matrix3 lhs, Vector3 rhs


         Name: SetScaled
         Description: sets the scale of an entity
         Type: Function
         Parameters: float x, float y, float z

         Name: SetScaled
         Description: sets scale using a vector 3
         Parameters: vector3 v

         Name: Scale
         Description: Sets the scale
         Type: function
         Parameters: float X, float Y, float Z


         Name: SetRotateX
         Description: 
         TYpe: function
         Parameters: double radians

         Name: rotateX
         Description:
         Type: function
         parameters: double radians

         Name: SetRotateY
         Description:
         Type: function
         Parameters: double radians

         Name: RotateY
         Description: 
         Type: double radians

         Name: SetRotateZ
         Description:
         Type: double radians
         parameters: double radians

         Name: RotateZ
         Description: 
         Type: double radians
         parameters: double radians

         Name: setEuler
         Description:
         Type: function
         parameters: float pitch, float yaw, float roll

         Name: SetTranslation
         Description: sets the translation
         Type:  function
         parameters: float x, float y, float z

         Name: Translate
         Description: translate the entity
         Type: function
         parameters: float x, float y, float z

         Name: set
         Description: 
         Type: function