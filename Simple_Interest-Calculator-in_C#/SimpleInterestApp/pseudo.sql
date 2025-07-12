PROGRAM SimpleInterestCalculator

START

    // Step 1: Initialize variables
    SET principal = 0
    SET rate = 0
    SET time = 0
    SET interest = 0

    // Step 2: Display initial values
    DISPLAY "Initial Values:"
    DISPLAY "Principal = 0, Rate = 0, Time = 0, Interest = 0"

    // Step 3: Read user inputs
    DISPLAY "Enter the Principal amount:"
    INPUT principal

    DISPLAY "Enter the Rate of interest (in %):"
    INPUT rate

    DISPLAY "Enter the Time (in years):"
    INPUT time

    // Step 4: Calculate Simple Interest
    interest ← (principal × rate × time) ÷ 100

    // Step 5: Display the result
    DISPLAY "Simple Interest = " + interest

END
