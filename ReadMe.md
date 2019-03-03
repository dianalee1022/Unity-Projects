# EECS4471 Labs

## Table of Contents
1. [Lab2](#lab2)
2. [Lab1](#lab1)
3. [Lab0](#lab0)

## Lab2
### Description
In this particular laboratory experiment, I explored Unity's UI component, including buttons, sliders, toggles and others. Different types of Canvas were utilized as well; the overlay type one was used to control the overall scene while the local world coordinate canvas was used to control individual particles. Combining these UI components with Unity's physics engine, I wrote scripts that control the light intensity, change gravity, add prefabs on random coordinates and apply impulse force. Initially, these actions were triggered by mouse movements (e.g. clicking the buttons, toggling the switches, etc.) and then mapped to different keys on Oculus' controllers. The more in-depth instructions on how to interact with different components are provided below.

### Credits
* The **tree**,**rocks**,**bone** and **well** prefabs used were provided by [23 Space Robots and Counting...](https://assetstore.unity.com/publishers/21779) which is available on the Unity Asset Store.

### Overall Menu
![Screenshot Image of Overlay Screen Menu](https://github.com/dianalee1022/Unity-Projects/blob/master/img/menu.PNG)
When a user enters the playmode, the overlay menu as shown above can be seen. The menu consists of multiple components:
* Toggles & Sliders to control light sources
* Slider to manipulate gravity & text representation
* Button to apply the new gravity value
* Button to add a particle on a random coordinate
* Button to apply impulse force

Overlay Screen Menu from Player perspective:
![Screenshot Image of Overlay Screen Menu](https://github.com/dianalee1022/Unity-Projects/blob/master/img/overview.PNG)

### Control Light sources
![Red and Blue Lights On](https://github.com/dianalee1022/Unity-Projects/blob/master/img/red%2Bblue_light.PNG)
As shown in the image above, the scene consists of 3 controllable light components: Blue, Green and Red lights.
1. Indicate your intention of controlling light source of your choice by clicking the toggle button (left side of each light source label)
2. Once the toggle button has a checkmark on, then play around with the intensity of the corresponding light source
* The light intensity modifies both intensity and range of the light object to maximize the controlling effects.

### Manipulate Gravity and Text representation
![Gravity Control](https://github.com/dianalee1022/Unity-Projects/blob/master/img/apply_gravity%2Bfreeze.PNG)
The gravity controller is located below the 3 light controllers. It consists of three items: the text title, the text label representing the current magnitude of gravity force, and the slider to control the magnitude.
1. The initial magnitude of the gravity force is set to 9.8.
* The gravity force usually takes a negative value as it's applied away from the earth. However, in this lab, for user's easier understanding, it'll be displayed as a positive value on UI.
2. To modify the value, simply drag the slider to the left or right.

### Apply the new gravity value
Right under the gravity controller, a button labelled "Apply Gravity (To All)" will allow the user to apply the new gravitational force to all newly added particles.
1. Set the gravity magnitude to a desired value
2. To apply the new gravity, press the button labelled "Apply Gravity (to All)."
3. To stop applying the gravity to all particles, press the *freeze* button.

### Add a particle on a random coordinate
![Add new objects](https://github.com/dianalee1022/Unity-Projects/blob/master/img/add_objects.PNG)
Outside of the panel, two additional buttons can be found near the left bottom corner of the overlay screen.
1. Press the button labelled "Add Objects" to add a purple sphere on a random coordinates with randomly selected orientation

### Apply impulse force
![Apply impulse force](https://github.com/dianalee1022/Unity-Projects/blob/master/img/apply_impulse_force.PNG)
The other button is to apply impulse force on all newly created particles.
1. Press "Surprise Force" button to apply impulse force on all newly created particles.
* The force will be applied in random directions.

## Lab1
### Description
For Lab1, I created a scene, simulating a simple catapult -- in the shape of a cannon -- and its targets -- in the shape of coins. A user can aim the targets using either keyboard keys or head gaze from Oculus VR device.

### Credits
The CameraRig used inside the scene is a prefab from Steam VR Plugin which is available on the Unity Asset Store.

### Shooting using keyboard
1. Aim a target
2. Press the following keys to move the cannon vent accordingly:
- *Left arrow key* : Left direction
- *Right arrow key* : Right direction
- *Up arrow key* : Lift-up the cannon vent
- *Down arrow key* : Lower the cannon vent
3. Press the *space bar* to fire a bullet toward the target

### Shooting using Oculus Rift
1. Put on the Oculus Rift and start appropriate software including Oculus/SteamVR
2. Aim a target by moving head
3. Once aimed, press the *trigger* on the *right hand controller* to fire a bullet

## Lab0
### Description
In this project, I created a simple diorama using assets from asset store and demonstrated a scene from a dessert. There are 3 scripts that control light, camera and cactus components.

### Camera Movements
0. The camera is set on transform mode as soon as the project starts
1. You can switch between transform and rotation by using 'T' and 'R' keys
2. You can transform/rotate the camera in the 4 directions (up, down, left and right) using 'W','X','A','D' keys.

### Light Components
> You can change the colour of light to Red, Green and Blue.
0. To activate the changes, press 'L' key.
1. If you press 'R', all lighting components will change their colour to Red.
2. If you press 'G', all lighting components will change their colour to Green.
3. If you press 'B', all lighting components will change their colour to Blue.
4. You can disable by pressing 'L' again.

### Cactus Components
> Similiar to the lighting omponents, you can change the colour of cactus components to Red, Green and Blue.
0. To activate the changes, press 'C' key.
1. If you press 'R', all cactus components will change their colour to Red.
2. If you press 'G', all cactus components will change their colour to Green.
3. If you press 'B', all cactus components will change their colour to Blue.
4. You can disable by pressing 'C' again.
