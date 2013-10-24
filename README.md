===A Launchy# plugin to access CSV files directly in Launchy===

Requirements:
 * Launchy# (https://github.com/kshahar/launchysharp)

Uses:
 * A Fast CSV Reader (http://www.codeproject.com/Articles/9258/A-Fast-CSV-Reader)
 * C# IniFiles (https://github.com/gotson/c-sharp-inifiles)

Binaries:
http://aves.free.fr/github/csvy/

*You can also code your own actions !*
Just implement the *Csvy.Action.Interface* and drop the DLL in the *plugin* folder.

----
1.3.2 [10/09/2012]
----
 * BUG fix anchor of duplicate icon when resizing main window

----
1.3.1 [18/05/2012]
----
 * ENH Actions and Referentials can now be duplicated using the Duplicate button
 * ENH List icons are greyed out if no item is selected
 * ENH Dialog titles now depends on situation
 * BUG Action Designer: Design button doesn't work for IconPath
 * BUG Action Designer: IconPath is not reset to blank when adding a new action
 * BUG Referential list: up and down arrows are not working

----
1.3 [31/05/2011]
----

 * ENH Add functions $env,$if,$regex,$json
 * ENH Replaced my self-implementation of a CSV Parser by http://www.codeproject.com/KB/database/CsvReader.aspx
 * ENH Action name can now use %HEADER% tokens and $FUNCTIONs
 * ENH Icon support for Action, Referential items and Referential
 * ENH CSV parser options are now available in the Referential dialog
 * ENH Action Arguments are now split first (using CSV Parser), then replaced
 * ENH Actions with the same name are now allowed
 * ENH Navigation through the CSV content is now possible in the Expression Designer dialog
 * ENH Preview expression with the current item in the Expression designer
 * ENH Windows are always on top only if Launchy is configured to be always on top
 * ENH Double-click on the referential list opens the edit dialog
 * ENH Replacement of Explorer action by Command action
 * ENH Actions can now be developped by anyone by implementing the BaseAction class of Csvy.Action.Interface.dll (Existing actions have been moved to external DLLs)
 * FIX ActionDesigner: Condition textbox was not cleared correctly when showing the dialog
 * FIX Exception when the .csv file had a column called ID
 * FIX %HEADER% tokens were not replaced correctly if the header contained a white space
 * FIX Removed a debug message box when the CSV file could not be read correctly
