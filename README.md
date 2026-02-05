# Coffee Shop Console Game (C#)

A simple **C# console-based management game** where you run a small coffee shop.  
You buy supplies, brew coffee, sell coffee and croissants (“kruvasan”), and manage your budget across multiple days.

---

## Features

- **Budget system** (starts at **100 Z**)
- **Coffee flow**
  - Buy coffee packages
  - Each coffee package gives **3 coffee shots**
  - Brew coffee using shots → produces **fresh cups**
- **Croissant flow**
  - Buy kruvasan packages
  - Open a package → adds **5 kruvasan** to the tray
- **Order limits per day**
  - After **6 orders**, the day ends automatically
  - Manual “End of the Day” works only after **3 orders** (unless auto-ended)
- **Day system**
  - Day counter increases
  - Fresh coffee resets at the end of each day
  - Every **even day**, kruvasan tray resets to 0

---

## Menu Options

1. Buy coffee package  
2. Brew coffee  
3. Sell cup(s) of coffee  
4. Buy kruvasan packages  
5. Open 1 kruvasan package  
6. Sell kruvasan  
7. End of the Day  
8. Quit Game  

---

## Rules / Pricing

### Coffee
- **Buy coffee package:** 5 Z each  
- **1 package → 3 shots**
- **Brew coffee:** consumes **1 shot** and produces **5 cups**
- **Sell coffee:** 2 Z per cup

### Kruvasan
- **Buy kruvasan package:** 10 Z each
- **Open package:** adds **5 kruvasan**
- **Sell kruvasan:** 3 Z each

---

## How to Run

### Using .NET CLI
1. Clone the repo:
   ```bash
   git clone https://github.com/<your-username>/<your-repo>.git
   cd <your-repo>

