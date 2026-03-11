# Chord Trivia Trainer

A command-line program designed to improve harmonic awareness by training the user to quickly identify and construct chords.

The program generates random chord challenges and asks the user to determine the correct notes of the chord. It can also generate specific chord voicings and inversions to practice thinking about harmony in a structured way.

The main goal of the project is to help musicians — especially guitar players and composers — develop faster mental recognition of chord structures such as triads, seventh chords, and extended chords.

Instead of memorising shapes mechanically, the program encourages understanding how chords are constructed from intervals.

---

## Features

* Random chord trivia exercises
* Practice identifying chord tones
* Support for different chord types:

  * Triads
  * 7th chords
  * 9th chords
  * 13th chords
* Inversion training
* Guitar-oriented practice (specific string sets such as 6-5-4-3)
* CLI menu system to select practice modes

---

## Example Challenge

The program may generate exercises such as:

```
Play: A/C# Major on strings 6-5-4
```

The user must determine the chord tones and their correct order based on the inversion and string set.

Another example:

```
What notes form a Bb minor triad?
```

Expected answer:

```
Bb Db F
```

---

## Technical Overview

The program is implemented as a **console application**.

Core concepts used in the implementation:

* Music theory logic implemented in code
* Randomised question generation
* Menu-based CLI navigation
* Chord construction using interval formulas
* Support for sharps and flats

Internally, the program models:

* Notes
* Intervals
* Chord formulas
* Inversions
* Guitar string groups

The system dynamically builds chord questions using these rules.

---

## How to Run

### 1. Clone the repository

```
git clone https://github.com/yourusername/chord-trivia-trainer.git
```

### 2. Navigate to the project folder

```
cd chord-trivia-trainer
```

### 3. Run the program

If using .NET:

```
dotnet run
```

---

## Menu Structure

```
1. Trivia
2. Play the chord
```

### Trivia Mode

The program asks theoretical questions about chord construction.

Example:

```
What notes form a D minor triad?
```

### Play Mode

The program generates practical chord challenges, such as:

```
Play: A/C# Major on strings 6-5-4
```

This helps practice chord visualisation on the guitar.

---

## Why This Project Exists

Learning harmony often involves memorising shapes or diagrams. This tool approaches the problem from a different angle: **training the brain to calculate and recognise chords quickly**.

By repeatedly answering chord questions, the user builds stronger internal maps of:

* intervals
* chord construction
* inversions
* functional harmony

This approach helps musicians move beyond mechanical playing toward deeper musical understanding.

---

## Future Improvements

Possible extensions for the project:

* Add diminished and augmented chords
* Add scale-degree-based questions
* Support multiple instruments
* Add timed exercises
* Add MIDI playback for ear training
* Add a graphical interface

---

## License

This project is open source and available under the MIT License.
