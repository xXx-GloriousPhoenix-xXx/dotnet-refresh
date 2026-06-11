using REFRESH.GoF.Behavioral._01_ChainOfResponsibility;

var dialog = new Dialog(null, "https://wiki.com/main");

var panel = new Panel("Help on control panel");
dialog.AddChild(panel);

var button = new Button(null);
panel.AddChild(button);

button.ShowHelp();

var emptyPanel = new Panel(null);
var okButton = new Button(null);
dialog.AddChild(emptyPanel);
emptyPanel.AddChild(okButton);

okButton.ShowHelp();
