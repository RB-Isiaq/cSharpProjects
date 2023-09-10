int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

// Modification to include multiple labels

// Suppose our company decided to give all level 100 employees the title "Senior Associate" -- the same title as level 200 employees. As the developer, you decide to implement this by removing the first switch section belonging to the label case 100:, and instead allow both the case 100: and case 200: labels to execute the same switch section
switch (employeeLevel)
{
    case 100: // Both of the case labels 100 and 200 are now paired with the switch section that sets the title to the string value Senior Associate.
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");

// Converting the code above to switch statement

switch (product[0])
{
    case "01":
    type = "Sweat shirt";
    break;
    case "02":
    type = "T-Shirt";
    break;
    case "03":
    type = "Sweat pants";
    break;
    default: 
    type = "Other";
    break;
}

switch (product[1])
{
    case "BL":
    color = "Black";
    break;
    case "MN":
    color = "Maroon";
    break;
    default:
    color = "White";
    break;
}

switch (product[2])
{
    case "S":
    size = "Small";
    break;
    case "M":
    size = "Medium";
    break;
    case "L":
    size = "Large";
    break;
    default:
    size = "One Size Fits All";
    break;
}
Console.WriteLine($"Product: {size} {color} {type}");