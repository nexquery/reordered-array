# reordered array
My purpose in making this application is that sometimes I needed to reorder textdraw indexes while coding sa-mp server. I made an application where I can quickly edit the arrays instead of constantly editing them manually.

# How to use?
Insert data with array indexes into a text document and drag it on top of the application. On the screen that appears, specify which index number you want it to start from and print it out.

# Things to watch out for
You can reorder all array indexes, but you have to be careful that they only start with a number. Also this number should only be in a single index.

A simple example:
```c
// True
Array[0]
Array[index][0]
Array[index][0][idx]

// False
Array[0][10]
```

# A simple example
Save this data in a text document and drag it onto the app.
```c
Text_Player[playerid][15] = CreatePlayerTextDraw(playerid, 525.000, 140.000, "xxx);
PlayerTextDrawTextSize(playerid, Text_Player[playerid][15], 105.000, 210.000);
PlayerTextDrawAlignment(playerid, Text_Player[playerid][15], 1);
PlayerTextDrawColor(playerid, Text_Player[playerid][15], -1);
PlayerTextDrawSetShadow(playerid, Text_Player[playerid][15], 0);
PlayerTextDrawSetOutline(playerid, Text_Player[playerid][15], 0);
PlayerTextDrawBackgroundColor(playerid, Text_Player[playerid][15], 255);
PlayerTextDrawFont(playerid, Text_Player[playerid][15], 4);
PlayerTextDrawSetProportional(playerid, Text_Player[playerid][15], 1);

Text_Player[playerid][16] = CreatePlayerTextDraw(playerid, 525.000, 140.000, "xxx");
PlayerTextDrawTextSize(playerid, Text_Player[playerid][16], 105.000, 210.000);
PlayerTextDrawAlignment(playerid, Text_Player[playerid][16], 1);
PlayerTextDrawColor(playerid, Text_Player[playerid][16], -1);
PlayerTextDrawSetShadow(playerid, Text_Player[playerid][16], 0);
PlayerTextDrawSetOutline(playerid, Text_Player[playerid][16], 0);
PlayerTextDrawBackgroundColor(playerid, Text_Player[playerid][16], 255);
PlayerTextDrawFont(playerid, Text_Player[playerid][16], 4);
PlayerTextDrawSetProportional(playerid, Text_Player[playerid][16], 1);
```
In the application, enter the initial index value 0 and look at the new results.
```c
Text_Player[playerid][0] = CreatePlayerTextDraw(playerid, 525.000, 140.000, "xxx");
PlayerTextDrawTextSize(playerid, Text_Player[playerid][0], 105.000, 210.000);
PlayerTextDrawAlignment(playerid, Text_Player[playerid][0], 1);
PlayerTextDrawColor(playerid, Text_Player[playerid][0], -1);
PlayerTextDrawSetShadow(playerid, Text_Player[playerid][0], 0);
PlayerTextDrawSetOutline(playerid, Text_Player[playerid][0], 0);
PlayerTextDrawBackgroundColor(playerid, Text_Player[playerid][0], 255);
PlayerTextDrawFont(playerid, Text_Player[playerid][0], 4);
PlayerTextDrawSetProportional(playerid, Text_Player[playerid][0], 1);

Text_Player[playerid][1] = CreatePlayerTextDraw(playerid, 525.000, 140.000, "xxx");
PlayerTextDrawTextSize(playerid, Text_Player[playerid][1], 105.000, 210.000);
PlayerTextDrawAlignment(playerid, Text_Player[playerid][1], 1);
PlayerTextDrawColor(playerid, Text_Player[playerid][1], -1);
PlayerTextDrawSetShadow(playerid, Text_Player[playerid][1], 0);
PlayerTextDrawSetOutline(playerid, Text_Player[playerid][1], 0);
PlayerTextDrawBackgroundColor(playerid, Text_Player[playerid][1], 255);
PlayerTextDrawFont(playerid, Text_Player[playerid][1], 4);
PlayerTextDrawSetProportional(playerid, Text_Player[playerid][1], 1);
```
