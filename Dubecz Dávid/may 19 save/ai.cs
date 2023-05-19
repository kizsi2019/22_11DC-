using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Globalization;
using System.Diagnostics.SymbolStore;
using System.Text.Unicode;

namespace AiLoversv4
{
public partial class MainWindow : Window
{
private Process? pythonProcess;
private List<BubbleMessage> chatMessages = new List<BubbleMessage>();
private string chatHistoryFilePath = @"C:\Users\Xenon\Downloads\venv\venv\ChatHistory\History.txt";
public MainWindow()
{
InitializeComponent();
RenderOptions.SetBitmapScalingMode(InputTextBox, BitmapScalingMode.HighQuality);
TextOptions.SetTextRenderingMode(InputTextBox, TextRenderingMode.ClearType);
StartPythonProcess();

SendButton.Click += SendButton_Click;
InputTextBox.KeyUp += InputTextBox_KeyUp;
InputTextBox.Focus();
LoadChatHistory();
}

private void StartPythonProcess()
{
try
{
pythonProcess = new Process();
pythonProcess.StartInfo.FileName = "python";
pythonProcess.StartInfo.Arguments = "C:\\Users\\Xenon\\Downloads\\venv\\venv\\main.py";
pythonProcess.StartInfo.UseShellExecute = false;
pythonProcess.StartInfo.RedirectStandardInput = true;
pythonProcess.StartInfo.RedirectStandardOutput = true;
pythonProcess.StartInfo.CreateNoWindow = true;
pythonProcess.OutputDataReceived += PythonProcess_OutputDataReceived;
pythonProcess.Start();
pythonProcess.BeginOutputReadLine();

Style? senderStyle = FindResource("SenderStyle") as Style;
if (senderStyle != null)
senderStyle.Setters.Add(new Setter(TextBlock.FontFamilyProperty, new FontFamily(".C:\\Users\\Xenon\\Downloads\\venv\\venv\\FontSet\\seguiemj.ttf#Segoe UI Emoj")));

Style? messageStyle = FindResource("MessageStyle") as Style;
if (messageStyle != null)
messageStyle.Setters.Add(new Setter(TextBlock.FontFamilyProperty, new FontFamily(".C:\\Users\\Xenon\\Downloads\\venv\\venv\\FontSet\\seguiemj.ttf#Segoe UI Emoj")));
}
catch (Exception ex)
{
MessageBox.Show("Hiba történt a Python folyamat indításakor: " + ex.Message);
}
}

private void SendButton_Click(object sender, RoutedEventArgs e)
{
SendMessage();
}

private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
{

}

private void InputTextBox_KeyUp(object sender, KeyEventArgs e)
{
if (e.Key == Key.Enter)
{
SendMessage();
}
}

private void SendMessage()
{
string message = InputTextBox.Text;

if (!string.IsNullOrWhiteSpace(message) && pythonProcess != null)
{
pythonProcess.StandardInput.WriteLine(message);
SaveChatMessage("Én", message);
chatMessages.Add(new BubbleMessage { Sender = "Én", Message = message, ProfileImage = "C:\\Users\\Xenon\\Downloads\\venv\\venv\\Images\\xenon.png", Time = DateTime.Now });
UpdateChat();
InputTextBox.Text = string.Empty;
}
}

private void PythonProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
{
if (!string.IsNullOrWhiteSpace(e.Data))
{
string message = RemoveColorCodes(e.Data);
message = ConvertEmojisToUnicode(message);
SaveChatMessage("Zoé", message);
chatMessages.Add(new BubbleMessage { Sender = "Zoé", Message = message, ProfileImage = "C:\\Users\\Xenon\\Downloads\\venv\\venv\\Images\\zoeahogyolatjamagat.png", Time = DateTime.Now });
UpdateChat();
}
}

private string ConvertEmojisToUnicode(string message)
{
// Replace emojis with their Unicode representation
message = message.Replace(":)", "\U0001F603"); // Example: Replace :) with 😃

// Add more emoji replacements as needed

return message;
}

private string RemoveColorCodes(string? message)
{
if (message is null)
return string.Empty;

message = Regex.Replace(message, @"\u001b\[\d+m", ""); // Eltávolítja a színkódokat
message = message.Replace("\f", ""); // Eltávolítja a formfeed karaktert

return message;
}

private void SaveChatMessage(string sender, string message)
{
try
{
string prefix = (sender.ToLower() == "zoé") ? "Fogadva" : "Elküldve";
string formattedDate = DateTime.Now.ToString("yyyy. MM. dd. HH:mm:ss");

string formattedMessage = string.Format("[{0}]\n{1}\n({2}: {3})\n\n", sender, message, prefix, formattedDate);

File.AppendAllText(chatHistoryFilePath, formattedMessage);
}
catch (Exception ex)
{
MessageBox.Show("Hiba történt a beszélgetés mentése közben: " + ex.Message);
}
}


private void UpdateChat()
{
Dispatcher.BeginInvoke((Action)(() =>
{
ChatPanel.Children.Clear();

DateTime currentDate = DateTime.MinValue;

foreach (BubbleMessage bubbleMessage in chatMessages)
{
string cleanedMessage = RemoveColorCodes(bubbleMessage.Message);

// Dátum formázása nagy kezdőbetűs napokkal
string formattedDate = CultureInfo.GetCultureInfo("hu-HU").TextInfo.ToTitleCase(bubbleMessage.Time.ToString("dddd, HH:mm", CultureInfo.GetCultureInfo("hu-HU")));

// Az új dátum esetén elhelyezünk egy elválasztó szöveget
if (bubbleMessage.Time.Date > currentDate.Date)
{
TextBlock dateSeparator = new TextBlock();
dateSeparator.Text = formattedDate;
dateSeparator.Margin = new Thickness(0, 10, 0, 5);
dateSeparator.TextAlignment = TextAlignment.Center;
dateSeparator.FontSize = 14;
dateSeparator.FontWeight = FontWeights.Bold;
dateSeparator.Foreground = Brushes.Gray;
ChatPanel.Children.Add(dateSeparator);
currentDate = bubbleMessage.Time;
}

StackPanel messageContainer = new StackPanel();
messageContainer.Orientation = Orientation.Vertical;
messageContainer.Margin = new Thickness(0, 5, 0, 5);

TextBlock senderBlock = new TextBlock();
senderBlock.Style = FindResource("SenderStyle") as Style;
senderBlock.Margin = new Thickness(0, 0, 0, 0);
senderBlock.Text = bubbleMessage.Sender + ":";

Border bubbleBorder = new Border();
bubbleBorder.Style = FindResource("MessageBubbleStyle") as Style;
bubbleBorder.Child = new TextBlock()
{
Text = cleanedMessage,
Style = FindResource("MessageStyle") as Style,
MaxWidth = 500,
TextWrapping = TextWrapping.Wrap,
Foreground = bubbleMessage.Sender == "Én" ? new SolidColorBrush(Color.FromRgb(255, 255, 255)) : new SolidColorBrush(Color.FromRgb(0, 0, 0))
};

if (bubbleMessage.Sender == "Én")
{
senderBlock.HorizontalAlignment = HorizontalAlignment.Right;
senderBlock.Margin = new Thickness(0, 0, 10, 0);
bubbleBorder.Background = new SolidColorBrush(Color.FromRgb(0, 132, 255));
}
else if (bubbleMessage.Sender == "Zoé")
{
senderBlock.HorizontalAlignment = HorizontalAlignment.Left;
senderBlock.Margin = new Thickness(10, 0, 0, 0);
bubbleBorder.Background = new SolidColorBrush(Color.FromRgb(228, 230, 235));
}

StackPanel bubbleContainer = new StackPanel();
bubbleContainer.Orientation = Orientation.Horizontal;
bubbleContainer.Margin = new Thickness(0, 0, 55, 5);

Image profileImage = new Image();
profileImage.Source = new BitmapImage(new Uri(bubbleMessage.ProfileImage));
profileImage.Width = 55;
profileImage.Height = 55;
RenderOptions.SetBitmapScalingMode(profileImage, BitmapScalingMode.HighQuality);
profileImage.Clip = new EllipseGeometry(new Rect(0, 0, profileImage.Width, profileImage.Height));

if (bubbleMessage.Sender == "Zoé")
{
bubbleContainer.Children.Add(profileImage);
bubbleContainer.Children.Add(bubbleBorder);
bubbleContainer.HorizontalAlignment = HorizontalAlignment.Left;
bubbleContainer.Margin = new Thickness(10, 0, 0, 5); // Margó beállítása Zoé esetén
}
else
{
bubbleContainer.Children.Add(bubbleBorder);
bubbleContainer.Children.Add(profileImage);
bubbleContainer.HorizontalAlignment = HorizontalAlignment.Right;
bubbleContainer.Margin = new Thickness(0, 0, 10, 5); // Margó beállítása Én esetén
}

TextBlock timeBlock = new TextBlock();
timeBlock.Style = new Style(typeof(TextBlock));
timeBlock.FontSize = 10;
timeBlock.Foreground = Brushes.Gray;
timeBlock.Margin = new Thickness(55, 0, 0, 0);

if (bubbleMessage.Sender == "Én")
{
timeBlock.Text = "Elküldve: " + GetFormattedTime(bubbleMessage.Time) + "-kor";
timeBlock.HorizontalAlignment = HorizontalAlignment.Right;
timeBlock.TextAlignment = TextAlignment.Right;
timeBlock.Margin = new Thickness(0, 0, 55, 0); // Margó beállítása Én esetén
}
else if (bubbleMessage.Sender == "Zoé")
{
timeBlock.Text = "Fogadva: " + GetFormattedTime(bubbleMessage.Time) + "-kor";
timeBlock.HorizontalAlignment = HorizontalAlignment.Left;
timeBlock.TextAlignment = TextAlignment.Left;
timeBlock.Margin = new Thickness(55, 0, 0, 0); // Margó beállítása Zoé esetén
}

messageContainer.Children.Add(senderBlock);
messageContainer.Children.Add(bubbleContainer);
messageContainer.Children.Add(timeBlock);

ChatPanel.Children.Add(messageContainer);
}

ChatScrollViewer.ScrollToBottom();
}));
}

private string GetFormattedTime(DateTime time)
{
return time.ToString("yyyy. MM. dd. HH:mm:ss", CultureInfo.InvariantCulture);
}

private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
{
if (pythonProcess != null && !pythonProcess.HasExited)
{
pythonProcess.StandardInput.WriteLine("exit"); // Kilépés parancs küldése a Python folyamatnak
pythonProcess.WaitForExit(2000); // Várakozás a folyamat befejezésére (maximum 2 másodperc)
}

pythonProcess?.Dispose(); // Python folyamat leállítása és erőforrások felszabadítása
}

private void LoadChatHistory()
{
try
{
if (File.Exists(chatHistoryFilePath))
{
string[] lines = File.ReadAllLines(chatHistoryFilePath);
for (int i = 0; i < lines.Length; i++)
{
if (lines[i].StartsWith("["))
{
string sender = lines[i].Substring(1, lines[i].Length - 2);
string message = lines[i + 1];

Match timeMatch = Regex.Match(lines[i + 2], @"\((.+)\: (.+)\)");
if (timeMatch.Success)
{
string prefix = timeMatch.Groups[1].Value;
string formattedDate = timeMatch.Groups[2].Value;

DateTime time;
if (DateTime.TryParseExact(formattedDate, "yyyy. MM. dd. HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out time))
{
chatMessages.Add(new BubbleMessage { Sender = sender, Message = message, ProfileImage = sender == "Én" ? "C:\\Users\\Xenon\\Downloads\\venv\\venv\\Images\\xenon.png" : "C:\\Users\\Xenon\\Downloads\\venv\\venv\\Images\\zoeahogyolatjamagat.png", Time = time });
}
}
}
}

UpdateChat();
}
}
catch (Exception ex)
{
MessageBox.Show("Hiba történt a beszélgetés előzmények betöltése közben: " + ex.Message);
}
}

private void ClearChatHistory()
{
try
{
if (File.Exists(chatHistoryFilePath))
{
File.Delete(chatHistoryFilePath);
}
}
catch (Exception ex)
{
MessageBox.Show("Hiba történt a beszélgetés előzmények törlése közben: " + ex.Message);
}
}
}


public class BubbleMessage
{
public string? Sender { get; set; }
public string? Message { get; set; }
public string? ProfileImage { get; set; }
public DateTime Time { get; set; }

}
}