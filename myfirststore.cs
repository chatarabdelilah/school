using System;

namespace My_First_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");

            string store_name = "Salaam Shop";
            string user_name = Console.ReadLine();
            string[] item_names = { "The Noble Quran", "The Sealed Nectar", "Sahih Muslim", "Prayer mat", "Prayer bead" };
            int[] item_amounts = {60, 63, 40, 5, 33};
            double[] item_prices = { 9.99, 15.99, 22.99, 21.99, 2.99 };
            string[] item_descriptions = {
                "The Quran is the holy book of Allah, revealed to His Prophet Mohammed ﷺ. This release offers the original Arabic text, additionally it contains the english transliteration to make it accessible for both Arabic and English speakers. Perfect for whoever is looking to deepen himself in religion.",
                "The Sealed Nectar is an outstanding and comprehensive biography of the Prophet Mohammed ﷺ. It provides a detailed, well-researched account of his life. It was awarded first prize by the Muslim World League in a worldwide competition of biographies of the Prophet Mohammed ﷺ held in Mecca in 1979. The title of the book means a reference to verse 25 of Surah 83 of the Quran.",
                "Sahih Muslim is the second hadith collection of the hadith. A hadith is a narration of the Prophet Mohammed's ﷺ sayings.",
                "Sponge padded prayer mat with a masjid, moon and star texture.",
                "Prayer beads made of natural pebbles. These prayer beads have 33 pebbles."
            };
            string[] item_attributes = {
                "Arabic with English transliteration",
                "English",
                "English",
                "Green",
                "Black"
            };
            bool admin = false;
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Welcome {user_name} to {store_name}! We are dedicated to providing high-quality Islamic products that enrich your spiritual journey. Our carefully curated collection includes everything from prayer mats, Qurans, and prayer beads to other essential items designed to support your faith and daily rituals.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(new string('-', 100) + "\nProducts for sale:");

                for (int i = 0; i < item_names.Length; i++)
                {
                    if (item_amounts[i] == 0)
                    {
                        Console.WriteLine($"\nName: {item_names[i]}");
                        Console.Write("Amount: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sold out!");
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.WriteLine($"\nName: {item_names[i]}\nAmount: {item_amounts[i]}");
                    }
                }

                if (admin)
                {
                    Console.Write(new string('-', 100) + "\n1. View a product\n2. Purchase a product\n3. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Admin login\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("4. Quit\n5. Refill");
                    Console.WriteLine(new string('-', 100));
                    Console.Write("Choose an option and enter its corresponding number.\n\n> ");
                }
                else
                {
                    Console.Write(new string('-', 100) + "\n1. View a product\n2. Purchase a product\n3. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Admin login\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("4. Quit");
                    Console.WriteLine(new string('-', 100));
                    Console.Write("Choose an option and enter its corresponding number.\n\n> ");
                }

                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine(new string('-', 100));

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Which product do you wish to view?");

                        for (int i = 0; i < item_names.Length; i++)
                        {
                            Console.WriteLine($"\n{i + 1}. {item_names[i]}");
                        }

                        Console.Write("\n> ");

                        int item_choice = int.Parse(Console.ReadLine());

                        Console.Clear();


                        switch (item_choice)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine(new string('-', 100));

                                for (int i = 0; i <= 0; i++)
                                {
                                    if (item_amounts[i] == 0)
                                    {
                                        Console.Write($"Product: {item_names[i]}\n\nAmount: ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("Sold out!");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine($"\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Product: {item_names[i]}\n\nAmount: {item_amounts[i]}\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                }

                                Console.Write(new string('-', 100));
                                Console.ReadKey();
                                Console.Clear();

                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine(new string('-', 100));

                                for (int i = 1; i <= 1; i++)
                                {
                                    if (item_amounts[i] == 0)
                                    {
                                        Console.Write($"Product: {item_names[i]}\n\nAmount: ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("Sold out!");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine($"\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Product: {item_names[i]}\n\nAmount: {item_amounts[i]}\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                }

                                Console.Write(new string('-', 100));
                                Console.ReadKey();
                                Console.Clear();

                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine(new string('-', 100));

                                for (int i = 2; i <= 2; i++)
                                {
                                    if (item_amounts[i] == 0)
                                    {
                                        Console.Write($"Product: {item_names[i]}\n\nAmount: ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("Sold out!");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine($"\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Product: {item_names[i]}\n\nAmount: {item_amounts[i]}\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                }

                                Console.Write(new string('-', 100));
                                Console.ReadKey();
                                Console.Clear();

                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine(new string('-', 100));

                                for (int i = 3; i <= 3; i++)
                                {
                                    if (item_amounts[i] == 0)
                                    {
                                        Console.Write($"Product: {item_names[i]}\n\nAmount: ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("Sold out!");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine($"\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Product: {item_names[i]}\n\nAmount: {item_amounts[i]}\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                }

                                Console.Write(new string('-', 100));
                                Console.ReadKey();
                                Console.Clear();

                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine(new string('-', 100));

                                for (int i = 4; i <= 4; i++)
                                {
                                    if (item_amounts[i] == 0)
                                    {
                                        Console.Write($"Product: {item_names[i]}\n\nAmount: ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("Sold out!");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine($"\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Product: {item_names[i]}\n\nAmount: {item_amounts[i]}\n\nPrice: {item_prices[i]}\n\nDescription: {item_descriptions[i]}\n\nFormat: {item_attributes[i]}");
                                    }
                                }

                                Console.Write(new string('-', 100));
                                Console.ReadKey();
                                Console.Clear();

                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("Which product do you wish to buy?");

                        for (int i = 0; i < item_names.Length; i++)
                        {
                            Console.WriteLine($"\n{i + 1}. {item_names[i]}");
                        }

                        Console.Write("\n> ");

                        int product_choice = int.Parse(Console.ReadLine());

                        Console.WriteLine(new string('-', 100));
                        Console.Write("How many do you want?\n\n> ");

                        int amount = int.Parse(Console.ReadLine());

                        Console.WriteLine(new string('-', 100));

                        switch (product_choice)
                        {
                            case 1:
                                if (amount > item_amounts[product_choice - 1] || amount <= 0)
                                {
                                    if (item_amounts[product_choice - 1] == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("This product is sold out!");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write($"You have entered an invalid amount! ({amount})\nOur stock of this product contains no more than {item_amounts[product_choice - 1]}!\nPlease enter a number between 0 and {(item_amounts[product_choice - 1] + 1)} to purchase.");
                                    }
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    item_amounts[product_choice - 1] = item_amounts[product_choice - 1] - amount;

                                    double total_price = Math.Round(amount * item_prices[product_choice - 1], 2);
                                    double final_price = Math.Round(total_price + (total_price * 21) / 100, 2);

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"You have successfully purchased {amount} book(s) of {item_names[product_choice - 1]}!");
                                    Console.ResetColor();
                                    Console.Write($"{total_price}eu => ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write($"{final_price}eu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                break;
                            case 2:
                                if (amount > item_amounts[product_choice - 1] || amount <= 0)
                                {
                                    if (item_amounts[product_choice - 1] == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("This product is sold out!");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write($"You have entered an invalid amount! ({amount})\nOur stock of this product contains no more than {item_amounts[product_choice - 1]}!\nPlease enter a number between 0 and {(item_amounts[product_choice - 1] + 1)} to purchase.");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    item_amounts[product_choice - 1] = item_amounts[product_choice - 1] - amount;

                                    double total_price = Math.Round(amount * item_prices[product_choice - 1], 2);
                                    double final_price = Math.Round(total_price + (total_price * 21) / 100, 2);

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"You have successfully purchased {amount} book(s) of {item_names[product_choice - 1]}!");
                                    Console.ResetColor();
                                    Console.Write($"{total_price}eu => ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write($"{final_price}eu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                break;
                            case 3:
                                if (amount > item_amounts[product_choice - 1] || amount <= 0)
                                {
                                    if (item_amounts[product_choice - 1] == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("This product is sold out!");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write($"You have entered an invalid amount! ({amount})\nOur stock of this product contains no more than {item_amounts[product_choice - 1]}!\nPlease enter a number between 0 and {(item_amounts[product_choice - 1] + 1)} to purchase.");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    item_amounts[product_choice - 1] = item_amounts[product_choice - 1] - amount;

                                    double total_price = Math.Round(amount * item_prices[product_choice - 1], 2);
                                    double final_price = Math.Round(total_price + (total_price * 21) / 100, 2);

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"You have successfully purchased {amount} book(s) of {item_names[product_choice - 1]}!");
                                    Console.ResetColor();
                                    Console.Write($"{total_price}eu => ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write($"{final_price}eu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                break;
                            case 4:
                                if (amount > item_amounts[product_choice - 1] || amount <= 0)
                                {
                                    if (item_amounts[product_choice - 1] == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("This product is sold out!");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write($"You have entered an invalid amount! ({amount})\nOur stock of this product contains no more than {item_amounts[product_choice - 1]}!\nPlease enter a number between 0 and {(item_amounts[product_choice - 1] + 1)} to purchase.");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    item_amounts[product_choice - 1] = item_amounts[product_choice - 1] - amount;

                                    double total_price = Math.Round(amount * item_prices[product_choice - 1], 2);
                                    double final_price = Math.Round(total_price + (total_price * 21) / 100, 2);

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"You have successfully purchased {amount} {item_names[product_choice - 1].ToLower()}(s)!");
                                    Console.ResetColor();
                                    Console.Write($"{total_price}eu => ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write($"{final_price}eu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                break;
                            case 5:
                                if (amount > item_amounts[product_choice - 1] || amount <= 0)
                                {
                                    if (item_amounts[product_choice - 1] == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("This product is sold out!");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write($"You have entered an invalid amount! ({amount})\nOur stock of this product contains no more than {item_amounts[product_choice - 1]}!\nPlease enter a number between 0 and {(item_amounts[product_choice - 1] + 1)} to purchase.");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    item_amounts[product_choice - 1] = item_amounts[product_choice - 1] - amount;

                                    double total_price = Math.Round(amount * item_prices[product_choice - 1], 2);
                                    double final_price = Math.Round(total_price + (total_price * 21) / 100, 2);

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"You have successfully purchased {amount} {item_names[product_choice - 1].ToLower()}(s)!");
                                    Console.ResetColor();
                                    Console.Write($"{total_price}eu => ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write($"{final_price}eu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                break;
                        }

                        break;
                    case 3:
                        Console.Write("Enter the password, if you should be truthful:\n\n> ");

                        string password = "bismillah";
                        string input = Console.ReadLine();

                        Console.WriteLine(new string('-', 100));

                        if (input == password)
                        {
                            admin = true;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have entered the correct password and have been granted access to the admin panel!");
                            Console.Write("\nMore features coming soon...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            admin = false;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("You have not been truthful and neither have you entered a password correct!");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;
                    case 4:
                        Console.Write("May Allah grant you a long life!");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ResetColor();
                        Environment.Exit(0);

                        break;
                    case 5:
                        if (admin)
                        {
                            for (int i = 0; i < item_names.Length; i++)
                            {
                                if (item_amounts[i] == 0)
                                {
                                    Console.Write($"{i+1}. {item_names[i]} | Amount: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Sold out!\n");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                                else
                                {
                                    Console.WriteLine($"{i+1}. {item_names[i]} | Amount: {item_amounts[i]}\n");
                                }
                            }

                            Console.Write("Choose a product and enter its corresponding number to refill.\n\n> ");

                            int refill_choice = int.Parse(Console.ReadLine());

                            Console.WriteLine(new string('-', 100));
                            Console.WriteLine("By how much do you wish to refill?");
                            Console.Write("\n> ");

                            int refill_amount = int.Parse(Console.ReadLine());

                            Console.WriteLine(new string('-', 100));

                            switch (refill_choice)
                            {
                                case 1:
                                    item_amounts[refill_choice - 1] = item_amounts[refill_choice - 1] + refill_amount;
                                    
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($"You have successfully refilled a product's stock!\n\nName: {item_names[refill_choice - 1]} | Amount: {(item_amounts[refill_choice - 1])}");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                    break;
                                case 2:
                                    item_amounts[refill_choice - 1] = item_amounts[refill_choice - 1] + refill_amount;

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($"You have successfully refilled a product's stock!\n\nName: {item_names[refill_choice - 1]} | Amount: {(item_amounts[refill_choice - 1])}");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                    break;
                                case 3:
                                    item_amounts[refill_choice - 1] = item_amounts[refill_choice - 1] + refill_amount;

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($"You have successfully refilled a product's stock!\n\nName: {item_names[refill_choice - 1]} | Amount: {(item_amounts[refill_choice - 1])}");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                    break;
                                case 4:
                                    item_amounts[refill_choice - 1] = item_amounts[refill_choice - 1] + refill_amount;

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($"You have successfully refilled a product's stock!\n\nName: {item_names[refill_choice - 1]} | Amount: {(item_amounts[refill_choice - 1])}");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                    break;
                                case 5:
                                    item_amounts[refill_choice - 1] = item_amounts[refill_choice - 1] + refill_amount;

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($"You have successfully refilled a product's stock!\n\nName: {item_names[refill_choice - 1]} | Amount: {(item_amounts[refill_choice - 1])}");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("You are not an admin!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.ResetColor();
                        }

                        break;
                }
                Console.Clear();
            }
        }
    }
}
