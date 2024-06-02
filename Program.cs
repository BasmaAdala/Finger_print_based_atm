using System;

class Program
{
    static void Main(string[] args)
    {
        string storedFingerprint = "XXX-YYY-ZZZ";
        bool isAuthenticated = false;

        Console.WriteLine("Welcome to the Fingerprint Based ATM");

        for (int attempts = 3; attempts > 0; attempts--)
        {
            Console.WriteLine("Please scan your fingerprint:");
            string scannedFingerprint = Console.ReadLine();

            if (scannedFingerprint == storedFingerprint)
            {
                isAuthenticated = true;
                Console.WriteLine("Fingerprint Matched. Authentication Successful.");
                break;
            }
            else
            {
                Console.WriteLine($"Fingerprint not Matched. {attempts - 1} attempts remaining.");
            }
        }
        if (!isAuthenticated)
        {
            Console.WriteLine("Authentication failed. Exiting...");
            return;
        }







        // Once authenticated, continue with ATM operations
        Console.WriteLine("What would you like to do?");
        // Add ATM functionalities using switch statements
        Console.WriteLine("1. Withdraw");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Check Balance");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Withdrawal operation selected.");
                // Add withdrawal logic
                break;
            case 2:
                Console.WriteLine("Deposit operation selected.");
                // Add deposit logic
                break;
            case 3:
                Console.WriteLine("Check Balance operation selected.");
                // Add balance checking logic
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}