I plan to create an original(?) game in somewhat the same vein as flappy bird. I'm sure very similar games exist. i just cant think of any right now.
The game is a high score-based, endless skydiving game in which the player must avoid obstacles that drift left and right. I'll probably call it something simple in the style of NES games (like "Skydiving")


====================
         0      <--------- player 


----     -----------     <->  Obstacles drift left and right

                          ^ obstacles move up and player stays in place.
                          | gives the impression of falling

------------    ---      <->




-------    ---------     <->

=====================


The player can collect a powerup that stops the obstacles from drifting for a while
Im not yet sure if ill have the player move by having the charecter follow the cursor, or move by using the arrow keys. Ill experiment and see what feels right

Good outcome scenario is that i get non-drifting moving bars that kill the charecter. The powerup makes you invincible for a time instead of affecting the bars

Better outcome includes me keeping track of score, having bars that get faster and gaps that get thinner over time. Maybe a high-score table as well

Best outcome includes me importing a bunch of assets, polishing the game visually by adding a sky background with a paralax-scrolling cloud layer


I plan to use on onTriggerEnter a bunch. Ive done this several times in 3d but not in 2d. Ill do some reasearch to ensure the 2 arent too different. Tracking score will require editing text boxes which I know how o do conceptually using getcomponent, but ill need to look into syntax for doing so.