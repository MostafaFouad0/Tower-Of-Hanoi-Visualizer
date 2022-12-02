# Tower Of Hanoi Visualizer With Call Stack Visualizer
## Tower Of Hanoi Visualizer Using c# And Windows Form Application 





https://user-images.githubusercontent.com/54133941/205117556-1ad0994f-62f3-42ba-98ae-1d4dcbac217a.mp4





### if you Don't Know What Tower Of Hanoi is Please Check [This ](https://en.wikipedia.org/wiki/Tower_of_Hanoi) Link

#### you can see the Code of it here 
```cpp
void towerOfHanoi(int n, char from, char to,char tmp)
{
    if (n == 0) {
        return;
    }
    towerOfHanoi(n - 1, from, tmp, to);
    cout << "Move disk " << n << " from " << from << " to rod " << to << "\n";
    towerOfHanoi(n - 1, tmp, to, from);
}
```
### How i moved a Disk from a rod to another
- my idea was simple , if i want to move Disk '1' from rod 'A' to rod 'C' then i will calculate how many disks are stacked in rod 'C'
- and then calculate how many units are covered by these disks then add 10 units to make the new disk above them 
- here is the code of the Above explanation :
```cs
 int total = (A * add) + (10 * A)+(add); // A here means how many disks in rod 'A' , add is the amount of space between the disks
 // the 10 is the height of every disk
 total = 370 - total; /// the base of all rods are at y=370
 Disk1.Location = new Point(A_X, total);  //moving the Disk to rod 'A'
 // A_X is the X Coordinate of rod 'A'
``` 
![DEMO](https://user-images.githubusercontent.com/54133941/205326581-1501c829-04e1-442b-b643-93b3de80fcb2.JPG)

### Speed Buttons :
- by the help of the [system threading](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-7.0) in C# i was able to change the speed of the Visualizer 
- for example the default speed will be 1000ms which is 1 second 
- when the user changes the speed to 2X for example the speed will be changed to 800ms which is less than 1 second so the application transitions will be faster
- here is the code of the Above explanation :
```cs
private void button4_Click(object sender, EventArgs e)
        {
            speed = 1000;  //1X
        }

        private void button5_Click(object sender, EventArgs e)
        {
            speed = 800;   //2X
        }

        private void button6_Click(object sender, EventArgs e)
        {
            speed = 200;   //3X
        }
        
        
        // then i use Thread.Sleep(speed) to apply it on the Application Form 
```







