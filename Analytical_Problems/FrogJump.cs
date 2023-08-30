
/*
 Frog Jump 
(y-x)/d = next point.
y destination
x start
d distance
 */

FrogJump(0, 10, 10);

void FrogJump(double start, double end, double distance)
{
    var nextJump = ((end - start) / distance);
    while (end > 0)
    {        
        start = nextJump;
        end = end - start;
        nextJump = (end - start) / distance;
        Console.WriteLine($"{start} and {end}");
    }
}