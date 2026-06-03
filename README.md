# Dynamic Array Reverser (Console Application) 🌌🤖

A robust, crash-proof C# Console Application that demonstrates dynamic memory allocation, strict input validation, and algorithmic array reversing. This project is built to showcase defensive programming techniques in C#.

---

## 📌 Project Overview
Unlike standard static array exercises, this application takes a user-centered approach. It allows the user to dynamically define the size of the matrix, validates every single keyboard input in real-time, and flips the array elements securely using custom index mapping logic.

The program is meticulously engineered to ensure that accidental inputs (like letters, symbols, or negative numbers) never cause a system crash.

> 💡 **Pure Algorithmic Implementation:** This project explicitly avoids using the built-in `Array.Reverse()` shortcut. Instead, the array is reversed through a custom-built low-level logic loop to demonstrate a deep understanding of memory manipulation and pure algorithm design.

---

## 🚀 Key Engineering Features
Here is what makes this specific implementation advanced:

* **Pure Custom Reversing Logic:** Engineered a manual index-swapping algorithm from scratch, shunning ready-made high-level functions like `Array.Reverse()` to showcase core programming problem-solving skills.
* **Dynamic Array Sizing:** Removed hardcoded bounds, allowing the application to allocate memory for the array at runtime based on user specification.
* **Defensive Input Validation (`TryParse` Loops):** Implemented nested validation loops that intercept user input. If a user enters non-integer values or invalid bounds, the system handles it gracefully without throwing unhandled exceptions.
* **Smart UI/UX Mapping (`i + 1`):** Bridged the gap between developer logic (0-based indexing) and human intuition (1-based indexing) by dynamically shifting display numbers during input prompts.
* **Visual Separation of Concerns:** Kept data processing (the reversing logic loop) entirely separated from user interface rendering (the display loops).
* **Terminal Aesthetics:** Utilized `Console.ForegroundColor` toggles (Red, Green, Blue) to give clear visual feedback for errors, original states, and final mutated outputs.

---

## 🧠 Behind the Scenes: How the Reversal Logic Works
The application reverses the array elements in place using a precise logical offset calculation:
$$\text{nArrayReverse}[i] = \text{nReverseArray}[\text{nReverseArray.Length} - i - 1]$$

This mathematical mapping ensures that the pointer smoothly transitions from the tail end of the original array to the front end of the new array as the iterator increases.

---

## 👨‍💻 Author
* **Name:** ABDULKHALIQ ALSHAMRANI
* **GitHub:** [ABDULKHALIQ-ALSHAMRANI2](https://github.com/ABDULKHALIQ-ALSHAMRANI2)
* **Current Focus:** Completing my Web & Mobile Development Diploma

