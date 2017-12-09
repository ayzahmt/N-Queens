### N-Queens

Solution of N-Queens problem using backtracking programming

#### Purpose
To prevent to attack two queens each other and to ensure a queen can move horizontally, vertically or diagonally. İf a row, a column or a diagonal dimension have two queen, two queens can hit each other so the queens can not move.

#### Input

- Queen Count

#### Output

- NxN Chess Board

#### Solution Approach

- Find available cell for a queen and then place the queen. (set the matrix for this cell as 1)
- Solve the problem recursively. 
- İf the next queen can be placed, set again for the new cell as 1. İf it can not be placed, you should backtrack and set the current cell in matrix as 0 and then go on to find available cell.

#### Example
- Queen Count = 4

- Solution

|  	|  	| 1 	|  	|
|:-:	|:-:	|:-:	|:-:	|
| 1 	|  	|  	|  	|
|  	|  	|  	| 1 	|
|  	| 1 	|  	|  	|
