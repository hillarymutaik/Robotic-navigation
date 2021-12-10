# Robotic-navigation
This Assignment assesses the following module Learning Outcomes (from Definitive 
Module Document):
1. Have a knowledge and deep understanding of a variety of AL techniques 
and methods applicable across domains ranging from molecular 
computational biology and evolution of agents to behaviour-oriented and 
social robotics.
Robotic navigation
In this project you must program a simulated robot in Unity to autonomously navigate 
a track with a range of obstacles. You will be provided with a complete Unity project 
for this assignment and must not change any parameters of this project, the only 
aspect of this project you should edit is the RobotController.cs script. You are free to 
develop the controller in any way you see fit, the measure of success on this project 
will be how far the robot makes it round the course, the time it achieves, and the 
smoothness of the trajectory taken, this is an entirely results based assessment.
Example of basic expected behaviour
Click here to download starting project file (now includes 
controller script)
You must write a piece of code to control the robot to enable it to successfully 
complete the track provided. Your code must adhere to the following requirements:
• All code must be in the cs file
• Do not change the name of any pre-existing variables in the code.
• Do not modify the model in Unity, all students are being assessed against 
the same model meaning only your cs file will be used for testing.
• You are only allowed to use the Sensors provided in the model, theses are 
named:
o SensorFR – Must be a Raycast sensor (for proximity)
o SensorL1 – Must be a Raycast sensor (for proximity)
o SensorL2 – Must be a Raycast sensor (for proximity)
o SensorL3 – Must be a Raycast sensor (for proximity)
o SensorR1 – Must be a Raycast sensor (for proximity)
o SensorR2 – Must be a Raycast sensor (for proximity)
o SensorR3 – Must be a Raycast sensor (for proximity)
o SensorOR – Must be an eulerAngles sensor (for robot 
orientation)
• Whilst you must use these sensors as defined above you can set these up 
however you see fit.
• You can rotate the sensors placed on the robot in your code but their 
physical position coordinates and scale must not change and any changes 
to the rotation of the sensor must be applied via the code.
• You must use the WheelCollider to facilitate the robots movements, these 
are named:
o frontLeftWheelCollider
o frontRightWheelCollider o rearLeftWheelCollider
o rearRightWheelCollider
• You must use Transform visualise the movement of the wheels, these are 
named:
o frontLeftWheelTransform
o frontRightWheelTransform
o rearLeftWheelTransform
o rearRightWheelTransform
You must use the following variables but can set these as you see fit, when setting 
these they must be set in the code:
• maxSteeringAngle – for the maximum steering angle
• motorForce – for the maximum motor power (speed)
• brakeForce – for the maximum breaking force (slowing down)
It is advised that you use at least the following two functions in your code:
• private void Start() – This will be called before the first frame is rendered so 
is useful for setting up parameters.
• private void FixedUpdate() – This is called around 50 times per second so 
ideal for physics elements.
Marks will be awarded for
Basic Model Requirements (20 marks)
• Wheels being driven appropriately using motorTorque
• Visual representation of wheels appropriately applied (steering and 
rotational movement visible)
• Sensors reasonably orientated to facilitate robots’ perception of the 
environment
• Robot physically capable of moving forwards
• Robot physically capable of steering to turn
Basic self-driving capabilities (70 marks)
• Successfully follows the track to the end without coming off
• Maintains a smooth optimal path in completing the track
• Avoids obstacles without collision
• Adjusts speed and power to wheels appropriately whilst traveling around 
the track
• Compensates for angled road surfaces
• Successfully completes track in a good time (not crawling round slowly)
• Successfully navigates tight spaces with multiple obstacles
A screen recording of your robot running (10 marks)
• Regardless of the performance you must provide a screen recording of 
your robot running from start to finish using the controller you developed 
to illustrating the performance of the robot.
VERY IMPORTANT NOTE:
You MUST submit a screen recording and it MUST be from the robot running the 
code you developed. Since you are being provided with the full project and must not 
change anything apart from the RobotController.cs code it will run identically on 
another machine. If there is an obvious difference in the performance of the file you 
submit against the recording that you submit this will be considered an attempted 
false representation and will subsequently receive a grade of 0.
What to Submit
This assignment requires the submission of:
• Upload one .txt file to Canvas containing all of the code from the C# file 
named RobotController.cs in your project – this is what your project will be 
marked on.
• Upload one video screen recording to Canvas of your robot running from 
start to finish on the track using the controller you developed.
