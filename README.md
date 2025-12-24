# BattleTank-MVC

This is a Tank Battle game made in Unity3D programmed in C++. I have used Model View Controller concept to setup movements, bullet firing, enemy object spawning.

The model represents the application's data, business validation and database access logics. The view handles the user interface (UI) and data presentation. The controlleris resposible for user input, processes requests, does the interaction with the model and selects the appropriate view to display.

Using MVC has benefits such as:
1. Separation of Concerns: It divides the application into manageable, independent units, making the code easier to maintain and extend.
2. Testability: The components, especially the model and controller, can be tested independently, which provides better support for Test-Driven Development.
3. Parallel Development: Different developers can work on the Model, View and Controller simultaneously.
4. Control over Behavior: It provides developers with full control over application behavior.

I have created 3 tanks which can be selected: red, green, blue. Each has varying fire rates and speeds which allows for customized gameplay based on user preference. The bullets use a particle system and trails for added effects.

Video demo:
