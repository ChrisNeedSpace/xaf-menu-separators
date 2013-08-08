;#DropDB SampleProjectEasyTest

#Application SampleProject.Win
#Application SampleProject.Web

#IfDef SampleProject.Win

*Action About...
 
*Action OK

#EndIf

#IfDef SampleProject.Web

*Action Choose Theme(Black Glass)

#EndIf
