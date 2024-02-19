using System.Data;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

//  If the user's subscription will expire in 10 days or less, display the message:
if (daysUntilExpiration == 0){
    Console.WriteLine("Your subscription has expired.");
       } 
       // If 5 days or less befire exp.
    else if (daysUntilExpiration <= 5 && daysUntilExpiration >= 2){
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
    } else if (daysUntilExpiration == 1){
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
    } else {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }


Console.WriteLine(daysUntilExpiration);