# Info

- This notations are reminders to myself in the future. If I need anything described here I probably will need to review it again. It is not a tutorial!

# Objects

- It's good to **separate the logics and the visualizations**, even inside of the game objects.
  - Ex:
  - In a game object called Player we include a child called Player Animator. Player will have everything related to the logics and Player Animator will have everything related to the visual part.

# Cinemachine

- Used to create **camera functions easily**.
- Easy to make the camera follow a target.
- Helps to create **movements on camera**, like "shakes".

# Game Input

- There is at least two ways to set the game input system. One of them is using the legacy game input way which is outdated but it is the most used so far because it's easier to teach in tutorials. The second way is using the new **input system**.
- To use the new input system it is **necessary to download** it in the unity's package manager.

# Delegate and C# Events

- A delegate is a way of telling C# which method to call when an event is triggered. For example, if you click a Button on a form, the program would call a specific method. It is this pointer that is a delegate. Delegates are good, as you can notify several methods that an event has occurred, if you wish so.
- In this project one of the use case was the interact button.

# Singleton Pattern

- This design pattern uses a single instance of a class to enable global access to the class members. Instead of having several instances of the same class, singletons have just one instance, and provide convenient access to that single instance.
- In this project I used this to create an instance of Player class to be used in the SelectedCounterVisual class.
