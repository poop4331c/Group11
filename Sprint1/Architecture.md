
# Program Organization

# Major Classes

# Data Design

# Business Rules

# User Interface Design

# Resource Management

# Security

# Performance

# Scalability

# Interoperability

# Internationalization/Localization

# Input/Output

# Error Processing

# Fault Tolerance

# Architectural Feasibility

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
