# Harry's DRE
 ### Challenge to create dice rolling experience 


# Concept & Prototype Video
## Turn daily object into any dice!

My idea is to use AR technology to capture any daily objects around you, for example dog, cat or bike. After the targeted object captured and processed by machine learning techniques (e.g. segmentation by CoreML), our AR app then converts the captured object into low poly form as a similar form of multi-faceted dice, each face has an unique number assigned of course (just like the dice!).  

Finally, user can roll this capture digital object onto the physical world, have fun and count the numbers. 

![image](https://user-images.githubusercontent.com/693098/180865606-14d4edbb-d572-4a9a-89e0-3f96893f330a.png)


## Prototype Video
Here's showcasing the AR capabilty and also UI, UX of our concept, despite the functionality of physical object recognition/segmentation and low-pol converter, I can still test the overall experience and idea to the user. 

[Demo 1](https://user-images.githubusercontent.com/693098/180850099-5c289d0b-a472-4a81-a542-2c84df9f4cd4.mov)

[Demo 2](https://user-images.githubusercontent.com/693098/180850352-941b672b-40d2-4184-89dd-f5f779dc6128.mov)



# Timeline & Process

1. Brief understanding - **0.5 hr** 
    1. key requirements from brief
        1. Use 3D framework that is compatible to MacOS or iOS
        2. Showcase technical and creative strenge of my own. 
        3. Deliverable: video documentation, functional build, source code and document.
    2. Setup my key points to deliver based on the idea of ‘dice rolling’
        1. Something can be thrown and rolled
        2. Some results can be determined after rolling (visual or logical result)
2. Directions & ideas - **1 hr**
    1. Direction
        1. Not only moving real dice roll experience to the digital (virtual) world
        2. Create some imagination, e.g. not be able easily to experience in the physical (real) world
        3. Focus on creative & design process, technical architecture & integration, software management and quick prototype 
    2. Idea/ concept
        1. Roll the objects from real scenes, e.g. car, bike, bench in the city
        2. Dr. Stranger uses gesture to rotate the object he pointed
        3. Use gesture to generate dice and throw to roll
        4. Use AR/MR would be cool
3. Technical feasibility & quick research - **1 hr**
    1. Principle: not reinventing wheel, leverage existing resource as much as possible
    2. Limitation: stricly time limit, need to jump on different projects at this moment
    2. Use Unity’s physical engine to make dice phsyics (e.g. Rigidbody, gravity, collision, etc.)
    3. Use Unity’s ARFoundation (ARKit) to build for iOS target with XCode toolchain
    4. Integrate ML to understand daily objects

4. Make a decision, prioritation & env. preparation - **1 hr**
    * Decide to do ' Turn daily object into any dice' idea 
    * Prioritation task:
    ``` demo creative process > user experience > material creation > calculation algorithm (points, swipe direction, physics..)  ```
    , e.g. Skip Core ML integratio, dice counts algorithm
    * Setup Unity project and related packages, assets
        1. ARKit player, XCode tool chian setup
        2. iOS X device
        
5. Design, Develop & Iteration
    1. Iteration & user test 1 (**2.5 hr**)
    * AR app dev with Unity ARFoundation 4.2
    * Get user feedback quickly by working AR prototype
    
    https://user-images.githubusercontent.com/693098/180852903-24840ed9-e736-401c-bf63-ed61c34aecbc.mov

    2. Iteration & user test 2 (**1 hr**)
        1. From the user's feedback: can't figure how to relate daily object and normal countable dice? 
        -> 
          * Add more meaningful visual and description (e.g. press to capture, swipe to roll)
          * Add dice like material to indicate there are numbers on the side
          * Showcase low-poly idea by showing just photos 
        2. Throwing physics experiement
6. Documentation & wrap-up - **1 hr**

# Technical Architecture & solution

Software block diagram 
![image](https://user-images.githubusercontent.com/693098/180872225-e0cfd03b-709b-41cb-8c21-66c98224278f.png)

Unity project setup
![Screen Shot 2022-07-26 at 4 24 28 AM](https://user-images.githubusercontent.com/693098/180872064-ea007397-474c-4d55-8f11-46ecb84834ca.png)

# Challenge
* Jumping on different projects/platform in the same time 
* Prioritize what I can do to showcase my strength
* Haven't had chance to work on CoreML yet

# Design & Technical Reference

* AR design material [https://www.figma.com/community/file/971376485724577565](https://www.figma.com/community/file/971376485724577565)

* iOS 15 design kit [https://www.figma.com/file/N1NETtHj6iDmtIfesNKsmw/iOS-15-UI-Kit-for-Figma-(Community)](https://www.figma.com/file/N1NETtHj6iDmtIfesNKsmw/iOS-15-UI-Kit-for-Figma-(Community))

* Dice material: [https://assetstore.unity.com/packages/templates/packs/dice-pack-light-165#publisher](https://assetstore.unity.com/packages/templates/packs/dice-pack-light-165#publisher)

* WebGL dice roll using ThreeJS [https://codesandbox.io/s/3d-dice-roll-using-three-js-9eb1b](https://codesandbox.io/s/3d-dice-roll-using-three-js-9eb1b)

* Tealyatina’s 3D dice roller [http://www.teall.info/2014/01/oCnline-3d-dice-roller.html](http://www.teall.info/2014/01/online-3d-dice-roller.html)

* RPG Dice Roller [https://dice-roller.github.io/documentation/](https://dice-roller.github.io/documentation/)

* AR Dice: [https://github.com/Federicoand98/AR-Dice/blob/main/ARDice_ARelazione.pdf](https://github.com/Federicoand98/AR-Dice/blob/main/ARDice_ARelazione.pdf)

* AR Foundation 4.2 [https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.2/manual/index.html](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.2/manual/index.html)

* Roll a dice tool [https://g.co/kgs/SYrQKK](https://g.co/kgs/SYrQKK)

* Implement CoreML in Unity [https://medium.com/@kevinhuyskens/implementing-coreml-in-unity-e91bcf80a3c5](https://medium.com/@kevinhuyskens/implementing-coreml-in-unity-e91bcf80a3c5)

* CoreML models Zoo for Segmentation [https://github.com/john-rocky/CoreML-Models#segmentation](https://github.com/john-rocky/CoreML-Models#segmentation)
* Low poly reference https://www.freepik.com/premium-vector/conceptual-polygonal-tree-abstract-low-poly-illustration_7812767.htm

