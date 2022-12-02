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
