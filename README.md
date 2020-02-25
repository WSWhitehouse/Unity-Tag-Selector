# Unity Tag Selector

Simple attribute that turns a normal string field into a dropdown of all available Tags in the inspector. Never misspell the name of a tag ever again.

[![Image from Gyazo](https://i.gyazo.com/084e5e63cce91a10e6b65bf985c7a102.gif)](https://gyazo.com/084e5e63cce91a10e6b65bf985c7a102)

## Installing & Using the Attribute

- Download the source code or check the [releases on this repository](https://github.com/WSWhitehouse/Unity-Tag-Selector/releases) for a specific Unity Package download or download the [Latest Unity Package](https://github.com/WSWhitehouse/Unity-Tag-Selector/releases/latest)
  - If you downloaded the Unity Package you will need to import it. `Assets -> Import Package -> Custom Package` and select the Unity Package you just downloaded
- Put a `[TagSelector]` attribute in front of any string field. Optional bool value to change the dropdown to the default Unity Tag Dropdown

  [![Image from Gyazo](https://i.gyazo.com/809dc931cc89430d02347916646b47fc.png)](https://gyazo.com/809dc931cc89430d02347916646b47fc)

- Done! You will now have a dropdown selector which includes all of the available Tags.
