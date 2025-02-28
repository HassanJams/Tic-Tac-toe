# Tic-Tac-Toe Acceptance Test

## Overview
This project tests the functionality of a Tic-Tac-Toe game, ensuring it behaves as expected under different scenarios.

## Test Scenarios

### ✅ Player Wins
- Player ('X') makes three in a row.
- Game announces "You WON!!!!".
- Winning buttons highlighted in green, losing ones in red.
- No further moves allowed.

### 🤖 Computer Wins
- Player makes random moves, allowing the computer ('O') to win.
- Game announces "Computer WON!!!!".
- Winning buttons highlighted in green, losing ones in red.
- No further moves allowed.

### 🔄 Tie Game
- Board fills with no winner.
- Game announces "CATS GAME!".
- No further moves allowed.
- **Known Issue**: Sometimes incorrectly displays "You WON!!!!".

### 🔁 Game Reset
- Clicking "Start New Game" clears the board.
- All buttons become interactive again.

## How to Run the Test
1. Start the Tic-Tac-Toe game.
2. Follow each test scenario step-by-step.
3. Verify the correct messages and behaviors.

## Notes
- The game correctly detects wins, ties, and resets.
- Minor glitch in tie detection remains.

### 🛠 Future Improvements
- Fix tie-game glitch.
- Optimize win detection logic.
