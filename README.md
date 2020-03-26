
# DogTopia
> Windows Application that allows the user to introduce a photo of a dog and have its breed classified.

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Screenshots](#screenshots)
* [Setup](#setup)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [License](#license)

## General info

* The application lets the user to introduce a photo of a dog and it will predict the dog's breed. Furthermore, the user can register to a database, and then log in to his account. He can add to the Shopping Cart dog food, accessories, as well as visit the website. The application tries to mimic an online payment as well. 

* The scope of this project was to strengthen our .NET (C#), Python, Database and Web skills. 

## Technologies
* Python 3.6 - for the classification feature. The algorithm uses a pre-trained Convolutional Neural Network (CNN) - ResNet50. 
* C# for the application - Windows Forms Application.
* SQL - to communicate with the Microsoft SQL Server database. 
* HTML for the structure of the website and CSS for visuals.

## Screenshots
<p align="center">
  <img src="https://imgur.com/ThKdTRQ.png" width="440" title="Classified dog">
  <img src="https://imgur.com/P04i5nK.png" width="440" title="Classified dog">
  <img src="https://imgur.com/7lj6cBt.png" width="440" title="User's account">
  <img src="https://imgur.com/L9giTNV.png" width="440" title="Shopping Cart">
  <img src="https://imgur.com/lZvNhD5.png" width="440" title="Login">
  <img src="https://imgur.com/WuyZR3f.png" width="440" title="Payment">
</p>

## Setup
* Install Visual Studio 2015 (or newer version) and Anaconda, along with Pycharm. 
* In order to install the required Python packages, you will have to create a virtual Python Environment:
###### 1) Open Anaconda Prompt
###### 2) Write the following commands: 
```
$ conda create --name classifier
$ conda activate classifier 
```
##### 3) Install the following packages:
```
$ conda install python=3.6
$ conda install -c conda-forge numpy
$ conda install -c conda-forge keras
$ conda install -c conda-forge tensorflow
$ conda install -c conda-forge scipy
$ conda install -c conda-forge pillow
$ conda install -c conda-forge tqdm
```

## Features
List of features ready and TODOs for future development
* The application can classify a dog in over 100 breeds and then the user can click on the Details button to find more information about that dog breed on the web.
* The application has a Login/Register feature.
* The application allows to add Food/Accessories to the Shopping Cart and to go to the website.

To-do list:
* Port the application to the web.

## Status
Project is: finished. 

## Inspiration
For the classifier algorithm, our source of inspiration was this wonderful Github project: https://github.com/udacity/dog-project. 

## License
>You can check out the full license [here](https://github.com/dogtopia-team/DogTopia/blob/master/LICENSE)

This project is licensed under the terms of the **MIT** license.
