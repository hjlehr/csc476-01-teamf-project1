README
Group F

Lehr, Castillo, Ruh

This is a basic labyrinth game that used a sphere as the main ball, spheres for the wrong and correct holes, and cubes to create the walls, borders, and the base of the board.

	-All the board components are together as a single game object, and the physics layer was changed so that they would not collide with 	each other.

	-A script was attached to the wrong holes so that it would reset the position of the ball, decrease the remaining lives, and reset the position of the board.

	-The score was calculated by multiplying the remaining lives with the points associated with each board. On the “Cameragaa.cs” I put the values of each board.

	-All the ball collisions are on the “ball.cs” script.

	-A script was used to align the texts objects to the size of the screen.

	-The movement script is in “BoardMovement.cs”, and it was done using the arrow keys on the keyboard and adjusting the rotation of the whole board object.

	-The calculations of the highest scores, and in the case of a tie the comparison of the timers is in the “HighScore.cs”.

	-The Restart buttons on the GameOver and Congratulations scenes reset all the values (like score, timer and lives), while the Restart buttons on the different levels just load the current 	scene again without affecting the scores.

	-There are four levels, it begins in easy, but as you go through it gets more and more complicated

	-We did use Git version control, but we created our own repo and worked through there.
