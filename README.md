# LinkCatcher 
Another poorly written crack at solving a problem for myself in C#.  
Linkcatcher handles links clicked from various applications (Outlook, Word, etc) by opening the link first in a window and then displaying the actual URL that is being sent to the browser (so far **only supports Chrome**).
You can then choose whether or not to continue opening the link:

![Some web 2.0 shit](/assets/images/screenshot.png  "love a good windows form")

Up to 3 additional parameters are also displayed as plain text in new lines underneath the link, in the event that the link you've clicked has them.

## Why would you want to do this?
I have on occasion accidentally clicked a link that has opened straight up in my browser.
If you're spending any amount of time looking at malicious URLs that might suddenly come to life with one misclick, the ability to stop or continue is a nice option to have.

You can also modify the URL on the fly before you open it any to add/remove any params or identifers.

## Installation
To install, merge the *.reg* file to your registry and place *LinkCatcher.exe* into the *`C:\temp\trash\`* directory (create it if it doesn't exist).
> Note that certain Chrome version upgrades will overwrite the registry key and again you will need to re-merge the *.reg* to the registry.
