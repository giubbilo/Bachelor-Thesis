# Design and implementation of a Xamarin app relative to the Marche Polytechnic University

The purpose of this thesis was to create an Android app in order to help the students to search timetables, schoolrooms, maps and opening hours of the offices.

The app has been developed using *Xamarin.Android* (C# and XML/XAML), Visual Studio 2017, an emulated Android device and a real one with two different version of the OS. 

The file has been written using *MiKTeX* that provides the tools necessary to prepare documents using the TeX/LaTeX markup language and *Texmaker* as text editor.

## Chapters
1. Xamarin introduction
2. Requirements analysis
3. Design of the data component (Entity-Relationships model)
4. Design of the application component (Architectural scheme, Process Flow, Mockup)
5. Implementation (C# and XML/XAML code)
6. Conclusions

Bibliography

## How to deploy the app
The app has been created using Android 8.1 (API 27). I updated the config files in order to run it using Android 13 (API 33) and it works.

If you want to try you should need to install:
- Visual Studio 2022 (I used the Community edition)
- .NET Multi-platform App UI development 
- Xamarin and Xamarin Remoted Simulator
- Android SDK 13
- Android emulated device
  - Model: Pixel 5
  - Android 13.0 - API 33
  - Google APIs : Yes
  - Processor: x86_64
  - Memory: 1 GB
  - Resolution: 1080 x 2340 - 440 dpi

After installing these components, you need to:
- import the project double clicking the *UNIVPM.sln* file
- start the emulated device
- select *Release* in the menu and click on the button *Pixel 5 - API33 ...* ![immagine](https://user-images.githubusercontent.com/92432998/222914586-e6a53c40-7245-46d8-93d1-c7f8b25e2296.png)
