![logo](https://raw.githubusercontent.com/ennerperez/multipanelcontrol/master/.editoricon.png)

# MultiPanel Control

Original article can be found at [http://www.codeproject.com/Articles/37397/A-Multipanel-Control-in-C](http://www.codeproject.com/Articles/37397/A-Multipanel-Control-in-C)

All credits are for [liron.levi](http://www.codeproject.com/Members/liron-levi), I decided to place it in GitHub to make a NuGet package, because is the most usefull control in Windows Forms to me.

// liron.levi thanks so much. Since 2009.

[![Build status](https://ci.appveyor.com/api/projects/status/dcnd5yngugd0vh8y?svg=true)](https://ci.appveyor.com/project/ennerperez/multipanelcontrol)
[![NuGet](http://img.shields.io/nuget/v/multipanelcontrol.svg)](https://www.nuget.org/packages/multipanelcontrol/)

---------------------------------------

See the [changelog](CHANGELOG.md) for changes.

## Table of contents

* [Implementing](#implementing)
* [Introduction](#introduction)
* [Background](#background)
* [History](#history)
* [License](#license)

### Implementing

**Add the library to your project**

Add the [NuGet Package](https://www.nuget.org/packages/multipanelcontrol/). Right click on your project and click 'Manage NuGet Packages...'. Search for 'multipanelcontrol' and click on install. Once installed the library will be included in your project references. (Or install it through the package manager console: PM> Install-Package multipanelcontrol).

### Introduction
For a long time, I needed a control that can act just like a tab control but without displaying any tabs. This control can be very useful because you can use the powerful forms designer to add many different pages in the same form. Otherwise you are forced to add a different user control for every page, which can be a real pain in the ass.

Unfortunately I didn't find one. In the past I even used a TabControl and pasted an ugly panel above the tabs so they won't be seen. Ugly Ugly Ugly .. 

In my final project, I needed one again and I've decided to solve this problem once and for all.

### Background 
Trying to be as lazy as I can, I've searched the Internet for something that I can copy paste with a minimal number of changes to my new control. 

After a few minutes, I found what I was looking for - an article on this very site [http://www.codeproject.com/KB/miscctrl/yatabcontrol.aspx](http://www.codeproject.com/KB/miscctrl/yatabcontrol.aspx) written by curtis schlak. This great article provided the basis for my control. 

### License
This article, along with any associated source code and files, is licensed under [A Public Domain Dedication](LICENSE)