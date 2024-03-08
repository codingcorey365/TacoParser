// Done
// Some of the tasks are done for you to get you started. 
// Objective: Find the two Taco Bells that are the farthest apart from one another.

// Done
// Calls method to Console.WriteLine string in the parameter.

// Done
// Use File.ReadAllLines(path) to grab all the lines from your csv file. 

// Done
// This will display the first item in your lines array

// Done
// Create a new instance of your TacoParser class

// Done
// Use the Select LINQ method to parse every line in lines collection

// Done
// Create two `ITrackable` variables with initial values of `null`.
// These will be used to store your two Taco Bells that are the farthest from each other.


// TODO 
// Optional: Log an error if you get 0 lines and a warning if you get 1 line

// Complete the Parse method in TacoParser class first and then START BELOW ----------

// Done
// Create a `double` variable to store the distance

// Done
// Add the Geolocation library to enable location comparisons: using GeoCoordinatePortable;
// Look up what methods you have access to within this library.

// -------------------------- NESTED LOOPS SECTION ----------------------------

// TODO:
// Create a loop to go through each item in your collection of locations.
// This loop will let you select one location at a time to act as the "starting point" or "origin" location.
// Naming suggestion for variable: `locA`

// TODO:
// Once you have locA, create a new Coordinate object called `corA` with your locA's latitude and longitude.

// SECOND FOR LOOP -
// TODO:
// Now, Inside the scope of your first loop, create another loop to iterate through locations again.
// This allows you to pick a "destination" location for each "origin" location from the first loop. 
// Naming suggestion for variable: `locB`

// TODO:
// Once you have locB, create a new Coordinate object called `corB` with your locB's latitude and longitude.

// TODO:
// Now, still being inside the scope of the second for loop, compare the two locations using `.GetDistanceTo()` method, which returns a double.
// If the distance is greater than the currently saved distance, update the distance variable and the two `ITrackable` variables you set above.

// -------------------------- NESTED LOOPS SECTION COMPLETE ----------------------------

// TODO:
// Once you've looped through everything, you've found the two Taco Bells farthest away from each other.
// Display these two Taco Bell locations to the console.