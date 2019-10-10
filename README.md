User stories: (Out of 105 points)

As a developer, if I don’t know what Lemonade Stand game is, I will play the game online for a bit to get familiar with the gameplay.

DONE - (5 points): As a developer, I want to make good, consistent commits.
DONE - (5 points): As a player, I want the ability to make a recipe for my lemonade, so thatI can include x-amount of lemons, x-amount of sugar, and x-amount of ice. 
DONE - (10 points): As a player, I want my daily profit or loss displayed at the end of each day, so that I know how much money my lemonade stand has made. I also want mytotal profit or loss to be a running total that is displayed at the end of each day, so that I know how much money my lemonade stand has made. 
DONE - (10 points): As a player, the price of product as well as weather/temperature should affect demand, so that if the price is too high, sales will decrease, or if the price is too low, sales will increase, etc. 
DONE - (10 points): As a player, I want each customer to be a separate object with its own chance of buying a glass of lemonade, so that how much lemonade is purchased and how much a customer is willing to pay will vary from customer to customer.
DONE - (10 points): As a player, I want a weather system that includes a forecast and actual weather, so that I can get a predicted forecast for a day or week and then what the actual weather is on the given day.
DONE - (10 points): As a developer, I want to implement the SOLID design principles as well as C# best practices in my project, so that the project is as well-designed as possible.
DONE - (10 points): As a player, I want my game to be playable for at least seven days.
DONE - (25 points): As a player, I want the basic Lemonade Stand gameplay to be present.

DONE - (10 points (5 points each)): As a developer, I want to pinpoint at least two placeswhere I used one of the SOLID design principles and discuss my reasoning, so that I can properly understand good code design. Minimum of two SOLID design principlesmust be used. 
I. Single Responsibility principle
 A.  This principle can be demonstrated in the ValidInt() function of the Validation class.  The string parameter 'Input' character values are located on a ASCII table.  The function's result is 'true' if those values are mapped to codes that represent arabic numerals 0-9, and 'false' if they do not.  this function does not identify valid 'float' values because it does not recognize the decimal point as a valid character; only characters 0-9 are considered valid, and the function's result is solely based on that.
 
II. Open/Closed principle
 A.  This principle can be demonstrated in the 'InventoryItems' classes, specifically in that since they inherit from the base class 'Item' they could be used in other aspects of the game.  There are inventory items and player items that inherit from the base 'Item', even though they serve very different purposes.  If changes to the game require other types of 'items', it is very likely they too could inherit from 'Item', since those new items would probably have a 'name' and exist in quantities that could be counted.  These could be more player items, other inventory items, or new 'game' class items.








Bonus Points:
(5 points): As a player, I want the game to be playable for more than one player, so that I can have multiple humans play each other or a human play a computer.

(5 points) As a developer, I want to integrate a Weather API, so that my game has real-time weather based on a current temperature and forecast.Classes You Will Use (you may need more than what is provided):Program WeatherCustomerGameInventoryPlayerStoreDayUserInterface


