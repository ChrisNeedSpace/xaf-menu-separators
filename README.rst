========================================
XAF Separators for Horizontal menu  v1.0
========================================
-----------------------------
Compatible with XAF versions:
-----------------------------
- **WEB only**
- 12.1.10

-----------
Description
-----------
This is a feature for **DevExpress eXpressAppFramework (XAF)** that provides Separators for Horizontal menu - simple easy-defined mechanism that integrates the navigation bar:

.. image:: https://raw.github.com/KrzysztofKielce/xaf-menu-separators/master/Screenshot.png


**HOW TO**

- You just need to set a new flag BeginGroup that can be accessed in any navigation nodes in any model designed diffs file.

**Significant files:**

+ SampleProject.Module\\Infrastructure\\NavigationItemSeparator\\SeparatorModelExtenders.cs   *(new)*
+ SampleProject.Module\\Module.cs   *- modified ExtendModelInterfaces()*
+ SampleProject.Module.Web\\Infrastructure\\ModelExtenders\\NavigationItemController.cs   *(new)*
+ SampleProject.Web\\Default.aspx   *- modified head section*
+ SampleProject.Web\\style.css   *(new)*

------------
Installation
------------
#. Install XAF_.
#. Get the source code for this code from github_, either using git_, or downloading directly:

   - To download using git, install git and then type 
     ``git clone git@github.com:KrzysztofKielce/xaf-menu-separators.git backup``
     at the command prompt (on Linux, Windows is a bit different)
   - To download directly, go to the `project page`_ and click **Download**

#. Convert the sample project to your current version via project converter tool (it's located in your menu start/DevExpress DXperience XX.X/Tools/DXperience XX.X Project Converter).
#. Run the project.

#. If you don't want to use the sample project, create your own and add the significant files. Each file in the repository has a namespace that indicates which project it refers to (Module, Module.Win, Module.Web, Win or Web). You need to copy the files to corresponding places in your project.


.. _XAF: http://go.devexpress.com/DevExpressDownload_UniversalTrial.aspx
.. _git: http://git-scm.com/
.. _github:
.. _project page: https://github.com/KrzysztofKielce/xaf-menu-separators


----------
Disclaimer
----------
This is **beta** code.  It is probably okay for production environments, but may not work exactly as expected.  Refunds will not be given.  If it breaks, you get to keep both parts.

-------
Release
-------
All code herein is Copylefted_.

.. _Copylefted: http://en.wikipedia.org/wiki/Copyleft

---------
About XAF
---------
The eXpressApp Framework (XAF) is a modern and flexible application framework that allows you to create powerful line-of-business applications that simultaneously target Windows and the Web. XAF's scaffolding of the database and UI allows you to concentrate on business rules without the many distractions and tedious tasks normally associated with Windows and Web development. XAF's modular design facilitates a plug and play approach to common business requirements such as security and reporting.

XAF's advantages when compared with a more traditional approach to app development are profound. See for yourself and learn why XAF can radically increase productivity and help you bring solutions to market faster than you've ever thought possible.

For more information, visit:

http://www.devexpress.com/Products/NET/Application_Framework/
