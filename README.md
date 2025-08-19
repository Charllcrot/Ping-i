# Pingüi

A virtual assistant like Clippy, but for Linux 🐧

---

## Overview

Pingüi is a playful virtual assistant that displays random helpful and funny messages using **Zenity** on Linux. Imagine Clippy, the classic Windows assistant, but penguin-themed and for your Linux system.

---

## Installation

### 1️⃣ Check Zenity

Open a terminal and type:

```bash
zenity --version
```

* If you see a version number, Zenity is already installed.
* If not, install it:

```bash
sudo apt update     # Optional but recommended
sudo apt install zenity
```

### 2️⃣ Install .NET SDK

Pingüi is written in C#, so the .NET SDK is required. Check if it’s installed:

```bash
dotnet --version
```

If not, install it (example for Ubuntu/Debian):

```bash
sudo apt update
sudo apt install dotnet-sdk-8.0
```

### 3️⃣ Download Pingüi

Clone the repository or download the source code:

```bash
git clone <your-repo-url>
cd <your-repo-folder>
```

### 4️⃣ Build Pingüi

```bash
dotnet build -c Release
```

This generates the executable in:

```
bin/Release/net8.0/PinguiApp
```

### 5️⃣ Run Pingüi

Run it with:

```bash
dotnet run
```

Or run the compiled binary directly:

```bash
./bin/Release/net8.0/PinguiApp
```

---

## Usage

* Pingüi will show messages in pop-up windows using Zenity.
* Stop Pingüi anytime by pressing **Ctrl + C** in the terminal.



## Notes

* Zenity is required for the pop-up messages.
* Pingüi is just a fun assistant and **not a virus**.



Or execute the compiled binary directly:

./bin/Release/net8.0/PinguiApp
