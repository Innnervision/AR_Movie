# AR_Movie

**AR_Movie** is an Augmented Reality (AR) mobile application that enables users to watch movies in their real-world environment using image tracking. This app leverages AR technology to display movies over specific images, providing a unique and interactive movie-watching experience.

![AR_Movie Screenshot](path/to/your/image.png)  <!-- Replace with actual image link -->

## Features

- **Image Tracking**: The movie is displayed when a predefined image is recognized by the app.
- **Mobile Compatibility**: Works on both Android and iOS devices with AR capabilities.
- **Interactive Viewing**: Users can interact with the AR content by moving their device around to change the view of the movie.
- **Real-Time Rendering**: Movies are rendered in real-time based on the position of the user's device.

## Prerequisites

Before you begin, make sure you have the following tools and software installed:

- **Unity** 2020 or higher.
- **AR Foundation** package for AR support on mobile devices (Android and iOS).
- **ARKit (iOS)** or **ARCore (Android)** for image tracking and AR functionalities.
  
Ensure your mobile device supports AR (most modern Android and iOS devices do).

## Installation

### Step 1: Clone the Repository

Start by cloning the repository to your local machine:

git clone https://github.com/Innnervision/AR_Movie.git

git clone https://github.com/Innnervision/AR_Movie.git
### Step 2: Open the Project in Unity
Open Unity.
Go to File > Open Project.
Navigate to the folder where you cloned the repository and select the project folder.
### Step 3: Install AR Packages
To enable AR functionality:

Go to Window > Package Manager in Unity.
Install the following packages:
AR Foundation
ARKit XR Plugin (for iOS)
ARCore XR Plugin (for Android)
### Step 4: Configure Project Settings
For Android:

Go to Edit > Project Settings > Player.
Select Android and ensure that ARCore is enabled.
In the XR Settings, enable AR and configure the settings as per the project requirements.
For iOS:

Go to Edit > Project Settings > Player.
Select iOS and ensure that ARKit is enabled.
In the XR Settings, enable AR and configure the settings as per the project requirements.
Step 5: Build for Your Target Platform
Go to File > Build Settings in Unity.
Select your target platform (Android or iOS).
Click Switch Platform to build for the chosen platform.
Once switched, click Build and Run to test the application on your mobile device.
Usage
Launch the AR_Movie app on your mobile device.
Point the device’s camera at a predefined image that has been configured for tracking.
The movie will automatically appear in the real-world space, floating above or in front of the image.
Interact with the AR movie by moving the device to change the viewpoint and explore the movie from different angles.
Demo Video
Here’s a quick demonstration of the app in action:

Click the image above to watch the demo.

## License
This project is licensed under the MIT License - see the LICENSE file for more details.

## Contact
For any questions or suggestions, feel free to reach out to the project maintainer:

## Sourav Mukherjee
Email: souravmukherjee7991@gmail.com
**LinkedIn**: https://www.linkedin.com/in/sourav-mukherjee-5547a1260/
