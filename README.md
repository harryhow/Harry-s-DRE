# Harry's DRE
 ### Challenge to create dice rolling experience 


# Concept & Prototype
## Turn daily object into any dice.  

My idea is to use AR technology to capture any daily objects around you, for example dog, cat or bike. After the targeted object captured and processed by machine learning techniques (e.g. segmentation by CoreML), our AR app then converts the captured object into low poly form as a similar form of multi-faceted dice, each face has an unique number assigned of course (just like the dice!).  

Finally, user can roll this capture digital object onto the physical world, have fun and count the numbers. 

## Protype Video
// TBD: video 



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
    2. Ideas
        1. Roll the objects from real scenes, e.g. car, bike, bench in the city
        2. Dr. Stranger use gesture to rotate the object he pointed
3. Technical feasibility & quick research - **1 hr**
    1. Principle: not reinventing wheel
    2. Use Unity’s physical engine (e.g. Rigidbody, gravity, collision, etc. )
    3. Use Unity’s ARFoundation to build for iOS target
    4. Integrate ML to understanding daily objects
4. Make a decision, prioritation & dev preparation - **1 hr**
    1. Setup Unity project and related packages, assets
        1. ARKit player, XCode tool chian setup
        2. 
5. Design & Develop
    1. iteration & user test #1 - **2.5 hr**
    2. iteration & user test #2 - **1 hr**
        1. Add little animation - 
            1. install 2D sprite package to edit animated sprite
6. Documentation & wrap-up - **1 hr**

### Technical Architecture

// TBD: sw architecture drawing





### Design & Technical Reference

* AR design material [https://www.figma.com/community/file/971376485724577565](https://www.figma.com/community/file/971376485724577565)

* iOS 15 design kit [https://www.figma.com/file/N1NETtHj6iDmtIfesNKsmw/iOS-15-UI-Kit-for-Figma-(Community)](https://www.figma.com/file/N1NETtHj6iDmtIfesNKsmw/iOS-15-UI-Kit-for-Figma-(Community))

* Dice material: [https://assetstore.unity.com/packages/templates/packs/dice-pack-light-165#publisher](https://assetstore.unity.com/packages/templates/packs/dice-pack-light-165#publisher)

* WebGL dice roll using ThreeJS [https://codesandbox.io/s/3d-dice-roll-using-three-js-9eb1b](https://codesandbox.io/s/3d-dice-roll-using-three-js-9eb1b)

* Tealyatina’s 3D dice roller [http://www.teall.info/2014/01/online-3d-dice-roller.html](http://www.teall.info/2014/01/online-3d-dice-roller.html)

* RPG Dice Roller [https://dice-roller.github.io/documentation/](https://dice-roller.github.io/documentation/)

* AR Dice: [https://github.com/Federicoand98/AR-Dice/blob/main/ARDice_ARelazione.pdf](https://github.com/Federicoand98/AR-Dice/blob/main/ARDice_ARelazione.pdf)

* AR Foundation 4.2 [https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.2/manual/index.html](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.2/manual/index.html)

* Roll a dice tool [https://g.co/kgs/SYrQKK](https://g.co/kgs/SYrQKK)

* Implement CoreML in Unity [https://medium.com/@kevinhuyskens/implementing-coreml-in-unity-e91bcf80a3c5](https://medium.com/@kevinhuyskens/implementing-coreml-in-unity-e91bcf80a3c5)

* CoreML models Zoo for Segmentation [https://github.com/john-rocky/CoreML-Models#segmentation](https://github.com/john-rocky/CoreML-Models#segmentation)