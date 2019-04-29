using UnityEngine;
using UnityEngine.UI;

public class OnMessageButtonClicked : MonoBehaviour
{
    public string messageValue;

    UniWebView webView;

    public void onMessageButtonClicked()
    {
        var webViewGameObject = new GameObject("UniWebView");
        webView = webViewGameObject.AddComponent<UniWebView>();

        webView.insets = new UniWebViewEdgeInsets(0, 0, 0, 0);
        webView.toolBarShow = true;
        webView.Load("http://" + messageValue);
        webView.Show();
    }
}
