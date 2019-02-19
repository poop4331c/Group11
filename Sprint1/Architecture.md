
# Program Organization

We will be designing and programming the game in Unity. Because of this, most of the program's organization is decided for us. Each piece of code will be attached to an item or feature in the game, eliminating much of the need for overall structural design. 

# Major Classes

# Data Design

We will keep a scoreboard of the top ten runs in a CSV file. At the start of the game, we will load the data in, and upon a qualifying user score, the file will be overwritten with the new score. 

Each line in the file will contain the initials of the user who earned the score, their total points, distance, time, and focus percentage. The initials will be a three line string, and the rest of the values will be integers. 

# Business Rules

As this is a game, we have no business rules. 

# User Interface Design
- [Main Menu](https://imgur.com/ZMTREOE)
- [Scoreboard](https://imgur.com/5nW9NJs)
- [Obstacles](https://imgur.com/oG9y2H3)
- [Environment] ()
- [Focus Meter](https://imgur.com/kdBu6G7)
- [Game Objects](https://imgur.com/QhZOPjJ)
# Resource Management

Our game is an "infinite scrolling" style game, where more of the map loads as the user continues forward, and more map is generated the longer the user lasts. In order to prevent memory bloat, we will be clearing the area behind the player as they progress, and loading no more than three tiles in advance. 

# Security

Nothing about the game will be secured. If the user would like to tamper with their own high score list, that's their decision to live with. 

# Performance

The game should be no more demanding than any other. Unless we do not properly clear map tiles that are no longer in use, nothing is likely to put any real strain on the computer. Performance, at this point, is not a concern. 

If there is a concern, the greatest concern is speed. This is a game in which the player is attempting to move through the map as quickly as possible, obtaining speed boosts and avoiding obstacles that would slow them down. Every care will be taken to ensure the map is able to be rendered at the speed we want, as skilled players may be moving extremely quickly, causing rendering speed to be an issue. 

# Scalability

# Interoperability

The EEG will be sending raw data over the COM port. Unity will read this data, but no other programs will. No data will be sent back, either. 

# Internationalization/Localization

While the menu buttons and directions will be in English, the rest of the game is without words. No effort will be made to localize the game in any way.

# Input/Output

# Error Processing

# Fault Tolerance

# Architectural Feasibility

The two major challenges in this project are the EEG interface and the procedural level generation. Other than these two elements, the game is a rather straightforward in creation. 

In order to understand the process of interfacing with the EEG, we experimented with interpreting our own mental signals, both by playing other games designed for EEGs and by using Arduino's serial monitor and Processing to visualize the data being transmitted. We are now confident that we understand how to connect to the EEG with Unity and how to interpret the data we do receive. 

The other challenge is procedural level generation. Research shows this is difficult to achieve and that it will take extensive programming. In order to mitigate this, we intend to create a variety of map tiles and simply attach them to each other semi-randomly. We believe that this will still present a challenge, but also allow us to guarantee the feasibility of our game. 

# Overengineering

Because Unity will be constantly and repeatedly using the code we write, it must be efficient and free of errors. Care will be taken to minimize the length of the code and ensure that all resources are dealt with appropriately. Any issues with the code are likely to multiply quickly. 

Although the code is running on Unity, a platform that takes care of much of the architecture for us, we will be controlling the player character with an external sensor of our own design. The sensor picks up a lot of noise and is likely to give values that can cause problems within the game. Because of this, the most care will be put into processing the information received from the EEG, eliminating noise, and allowing the rest of the game only to see sensible data. 

# Build-vs-Buy Decisions

Our group is not made up of game designers, neuroscientists, or artists. 

For the game engine, we have decided to use Unity. We are building the game from scratch in a new file there and learning to use the game engine using tutorials on Youtube and the Unity website. None of us have any experience with any kind of game design, but we are not using a template. All of the code will be written by us.

For the assets, we anticipate using 100% free assets downloaded from the internet. We will link all of the assets we end up using in a separate page to credit the artists who so generously offered their services to the public at no cost. If anything comes up in later sprints that we absolutely must have created, we will model it ourselves, but at this point we do not anticipate such a need. There are plenty of free 3D assets on the Unity Asset Store. 

As far as the EEG headset goes, we went took a split road. Higher-end, developer friendly EEG headsets are available at a hefty price appropriate for the high-end researchers we aren't. So, we purchased a discounted Star Wars Force Trainer toy headset, not intended for modification or use as a development platform, and modified it by cracking it open and soldering wires to the internals that pass serial information through an Arduino and into a USB connection to a PC. It's safe to say the warranty is void.

# Reuse

As none of us have ever done any game programming at all, we do not have any code to reuse. 

# Change Strategy
