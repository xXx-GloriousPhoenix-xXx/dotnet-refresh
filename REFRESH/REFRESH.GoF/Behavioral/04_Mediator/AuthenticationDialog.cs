namespace REFRESH.GoF.Behavioral._04_Mediator;

public class AuthenticationDialog : IMediator
{
    private string _title = "Log in";

    private bool _isLoginMode = true;

    private readonly Textbox _loginUsername;
    private readonly Textbox _loginPassword;

    private readonly Textbox _regUsername;
    private readonly Textbox _regPassword;
    private readonly Textbox _regEmail;

    private readonly Button _okButton;
    private readonly Button _cancelButton;
    private readonly Checkbox _loginOrRegisterCheckbox;

    public AuthenticationDialog()
    {
        _loginUsername = new Textbox(this);
        _loginPassword = new Textbox(this);
        _regUsername = new Textbox(this);
        _regPassword = new Textbox(this);
        _regEmail = new Textbox(this);
        _okButton = new Button(this);
        _cancelButton = new Button(this);
        _loginOrRegisterCheckbox = new Checkbox(this);
    }

    public void Notify(Component sender, string e)
    {
        if (sender == _loginOrRegisterCheckbox && e == "Checked")
        {
            _isLoginMode = false;
            _title = "Register";
            Console.WriteLine("[Mediator] Mode changed on: Sign up. Hiding unnecessary fields, showing fields for sign up.");
        }
        else if (sender == _loginOrRegisterCheckbox && e == "Unchecked")
        {
            _isLoginMode = true;
            _title = "Log in";
            Console.WriteLine("[Mediator] Mode changed on: Sigm in. Showing only login and password.");
        }

        if (sender == _okButton && e == "Click")
        {
            if (_isLoginMode)
            {
                Console.WriteLine("[Mediator] Validating and sending sign in form...");
            }
            else
            {
                Console.WriteLine("[Mediator] Validating and sending sign up form...");
            }
        }
    }
    public void SimulateToggleMode() => _loginOrRegisterCheckbox.Check();
    public void SimulateClickOk() => _okButton.Click();
}