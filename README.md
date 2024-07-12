# Dialogue of Self-Relationships

This is a real-time performance project combining AR technology with dance. We aspire to explore the possibilities between AR technology and physical performance. Additionally, we aim for this live performance to immerse the audience, allowing them to participate and present the performance together with the dancers.

## concept

In "Meditations on First Philosophy," Descartes explores the nature of self and existence through the argument of "Cogito, ergo sum" ("I think, therefore I am"). He attempts to determine what is real and knowable, addressing the doubts and affirmations regarding self-existence and identity.

Are you really yourself?

Who exactly is controlling you?

Who are you actually controlling?

"Dialogue of Self-Relationships" continually imagines and explores the relationship between the self and the "self." What is the relationship between a person and their various levels, aspects, and environments of self? "Dialogue of Self-Relationships" offers a new "cross-reality" in which participants are given the opportunity to dialogue with "themselves" and explore the "self."

## Performance

The performance offers a new reality in which participants are given the opportunity to engage in a dialogue with "themselves" and explore "the self."

![7月2日](https://github.com/09090909Hh/Dialogue-of-Self--Relationships/assets/161685338/64cb0fd5-f910-45ad-a9ea-735fd2bef61f)

Participants enter the performance reality holding their mobile phones or wearing AR enhancement devices.

   <img width="1449" alt="Screenshot 2024-07-11 at 21 34 08" src="https://github.com/09090909Hh/Dialogue-of-Self--Relationships/assets/161685338/0e517ae0-223d-458a-9bf8-aadac88c92de">

Both the live coder and participants, after putting on AR enhancement devices, can create sound effects in real-time based on the actions of the "two performers," making them participants in this reality as well.

![7月2日(6)](https://github.com/09090909Hh/Dialogue-of-Self--Relationships/assets/161685338/ad6387df-b9e4-43ff-8adf-ac21c74d243b)

## How does it work

In this project, there are three main components: choreography, AR production, and music production. These three components progress simultaneously and intertwine with each other.

### choreography

Choreographing along three main lines: "emotion," "motivation," and "time."

<img width="1376" alt="Screenshot 2024-07-11 at 20 40 39" src="https://github.com/09090909Hh/Dialogue-of-Self--Relationships/assets/161685338/769e03ee-56f5-4dff-8299-a873475f20cb">

Based on a constant frame within the venue, the relationship and dynamics between real people and virtual people are established, connected through AR visual lines.

### AR production

#### Spatial positioning


In the preliminary stage, Immersal spatial scanning was used to test the stability of the equipment and the feasibility in dim environments. It was found that Immersal could not perform well in recognizing the environment under low light conditions.

<img width="533" alt="Screenshot 2024-07-11 at 20 59 35" src="https://github.com/09090909Hh/Dialogue-of-Self--Relationships/assets/161685338/ae0a9f54-c1fe-4059-bf33-5f1fd9f0bb76">
<img width="467" alt="Screenshot 2024-07-11 at 20 59 35" src="https://github.com/09090909Hh/Dialogue-of-Self--Relationships/assets/161685338/c4432ffd-ea4c-4a9e-a8da-ae5eb6b7977d">

To achieve optimal stage performance, the AR positioning will use the origin-based activation method.

<img src="https://github.com/09090909Hh/Dialogue-of-Self--Relationships/assets/161685338/e7ade38c-8542-42e3-9537-317bd23bdbbd" style=" width:20%;">

#### Motion capture for the dance of virtual people

Depthkit technology is used for visual solutions, while Xsens is used for functional implementation solutions.

After dynamic video capture, post-processing software such as After Effects (AE) needs to be used before importing into Unity for the next stage of construction.

![屏幕截图 2024-07-03 153030](https://github.com/09090909Hh/Dialogue-of-Self--Relationships/assets/161685338/5a92a803-dde3-4a11-9040-f3c56c6814c5)

<img width="1300" alt="Screenshot 2024-07-11 at 21 31 45" src="https://github.com/09090909Hh/Dialogue-of-Self--Relationships/assets/161685338/2d89e21d-4ea7-447b-b30a-d53b019cd5c5">


Based on the animation captured with Depthkit technology, a second capture using Xsens motion capture technology is required. It is essential to ensure that the movements in both captures are consistent. After Xsens motion capture, all skeletal information of the dancer's body in motion can be obtained in Unity, enabling the realization of various functional effects.

<img width="1399" alt="Screenshot 2024-07-12 at 11 00 52" src="https://github.com/user-attachments/assets/86c43ac8-6af8-4324-b2e3-60c8f444865d">

<img width="1080" alt="Screenshot 2024-06-25 at 00 32 16" src="https://github.com/user-attachments/assets/3dff4179-aaee-4f4f-9e8b-1bdee05f11f7">

#### visual effect and functional realization

Scene and wireframe

First, create a curve model in Blender and import it into Unity. Then, use Shader Graph to create a dynamic flowing effect.

<img width="1088" alt="Screenshot 2024-07-12 at 11 17 35" src="https://github.com/user-attachments/assets/4bfd8473-ce2b-4424-966b-01c3c467d685">

Special effects and functions

Create a VFX linear effect, then bind the start and end points of the line to the hands of the real people captured by Xsens and the virtual people captured by Depthkit, respectively.

<img width="1299" alt="Screenshot 2024-07-12 at 11 29 22" src="https://github.com/user-attachments/assets/5ef6e072-5d65-4051-9f0b-63d965665dbe">

Use the spine bone of the virtual people as the attraction point for the magnet component in the deform plugin, enabling real-time attraction of scene content as the virtual people move.

<img width="1041" alt="Screenshot 2024-07-12 at 11 38 56" src="https://github.com/user-attachments/assets/2d7382f6-0371-44e0-9c55-b774e4ce20e6">

#### music production

Create experimental music, enhancing details and improving the synchronization quality between sound and visuals. After wearing augmented reality devices, live coders and participants can create sound effects in real-time using Max based on the movements of the "two performers," becoming participants in this reality.

<img width="1240" alt="Screenshot 2024-07-12 at 11 51 47" src="https://github.com/user-attachments/assets/dcf5adc9-605d-4bef-a8e7-c465f0ed088a">



