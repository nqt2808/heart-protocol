using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace HeartProtocol
{
    public partial class MainWindow : Window
    {
        // =========================================================
        // CÁ NHÂN HÓA
        // =========================================================

        private const string HerName = "Tuyết Mai";


        private const string First =
            "Ở đây em sẽ thành thật với cảm xúc của mình nhé chị.\n\n" +

            "Em thích được ở bên chị, thích cách chị quan tâm em, " +
            "những cái đụng chạm của chị, ánh mắt chị nhìn em " +
            "và cả nụ cười đi kèm nữa.\n\n" +

            "Không biết chị có nhận ra không, " +
            "nhưng từ lúc biết chị, em thấy vai mình nhẹ hơn một chút.\n\n" +

            "Có những hôm đi làm stress muốn điên, " +
            "nhưng gặp chị một cái là tự nhiên vơi đi phân nửa.\n\n" +

            "Rồi em bắt đầu thích được ở cạnh chị " +
            "nhiều hơn mức em tưởng.";


        private const string Second =
            "Em cũng bắt đầu muốn biết nhiều hơn về một ngày của chị.\n\n" +

            "Hôm nay chị ăn chưa, có mệt không, có nhiều việc không, " +
            "có chuyện gì làm chị buồn không, tối qua chị ngủ đủ giấc không...\n\n" +

            "Những chuyện nhỏ vậy thôi mà tự nhiên em lại muốn biết.\n\n" +

            "Nhưng càng để ý thì em càng rén :))))\n\n" +

            "Có lúc em muốn chủ động tiến thêm một bước, " +
            "nhưng lại không chắc chị đang nhìn em như thế nào.\n\n" +

            "Có khi em còn không biết những cái sign của chị là thật, " +
            "hay tại em để ý chị quá nên tự suy diễn nữa :))))\n\n" +

            "Em yếu nghề lắm chị ơi.";


        private const string Last =
            "Em biết giữa chúng ta có khoảng cách.\n\n" +

            "Tuổi tác, trải nghiệm, cách nhìn cuộc sống " +
            "và cả những chuyện khó nói mà em nghĩ mình không nên tự ý bước vào " +
            "nếu chị chưa muốn kể.\n\n" +

            "Em cũng biết mình còn non, " +
            "chưa đủ trải đời để nói rằng em hiểu hết mọi thứ.\n\n" +

            "Nhưng nếu một ngày chị mệt và cần một người ngồi nghe chị ràm, " +
            "em nghe.\n\n" +

            "Nếu chị bận đến quên ăn, em nhắc chị ăn.\n" +

            "Nếu chị cần người đón đưa, em sẵn lòng.\n\n" +

            "Còn nếu có lúc chị chỉ cần một vòng tay " +
            "và không muốn nói gì cả...\n\n" +

            "em cũng muốn cho chị vòng tay đó.\n\n" +

            "Em không hứa mình có thể bù đắp những điều không vui đã qua.\n\n" +

            "Em chỉ muốn nếu chị cho phép, " +
            "em sẽ đem những gì tốt nhất em có đến cho chị.\n\n" +

            "Ở bên chị em không cần phải gồng.\n\n" +

            "Và em cũng muốn một ngày nào đó, " +
            "mình có thể trở thành một nơi đủ yên để chị dựa vào.";


        // =========================================================
        // LỜI TỎ TÌNH
        // =========================================================

        private const string FinalMessageBeforeBoom =
            "Em đã tự hỏi mình khá nhiều lần.\n\n" +

            "Đây là quý chị, ngưỡng mộ chị, " +
            "hay chỉ vì được chị quan tâm nên em rung động?\n\n" +

            "Nhưng càng né thì em càng để ý.\n" +
            "Càng cố không nghĩ thì em lại càng nghĩ.\n\n" +

            "Đến lúc này em nhận ra...\n\n" +

            "Tuổi tác, generation gap, " +
            "thậm chí cả cái khoảng cách 15–20 tuổi " +
            "không còn là thứ làm em băn khoăn nhất nữa.\n\n" +

            "Thứ làm em suy nghĩ nhiều nhất...\n\n" +

            "là chị.\n\n" +

            "Trong đầu em cứ chạy mấy câu kiểu:\n\n" +

            "\"Ủa chị làm vậy là có ý gì?\"\n" +
            "\"Ủa chị có thích mình không ta?\"\n" +
            "\"Chị ơi đừng nhìn em vậy nữa, em ngại chết mất :))))\"\n\n" +

            "Nhưng rồi em biết cảm giác này " +
            "không chỉ đến từ mấy cái sign mập mờ đó.\n\n" +

            "Mà vì chị khiến một ngày mệt mỏi của em nhẹ đi.\n" +
            "Và em thích chính mình khi ở cạnh chị.\n\n" +

            "Rồi chẳng biết từ lúc nào...";


        private const string FinalMessageAfterBoom =
            "\n\nEm thích chị thật rồi :))))))\n\n" +

            "Không phải kiểu thích cho vui " +
            "hay một phút bốc đồng rồi mai quên.\n\n" +

            "Em muốn nghiêm túc bước thêm một bước về phía chị.\n\n" +

            "Nếu chị cũng có một chút cảm giác giống em, " +
            "thì cho em một cơ hội.\n\n" +

            "Còn nếu không, em vẫn tôn trọng chị, " +
            "tôn trọng câu trả lời của chị " +
            "và trân trọng những gì đã có giữa hai đứa.\n\n" +

            "Em chỉ không muốn giấu cảm xúc này mãi nữa.\n\n" +

            "Nên hôm nay em nói thật.\n\n" +

            "Em thích chị. ❤";


        // =========================================================
        // PLAYLIST NHẠC NỀN
        // =========================================================

        private readonly string[] backgroundTracks =
        {
            "yes-or-no.mp3",
            "nguoi-im-lang-gap-nguoi-hay-noi.mp3",
            "im-doi-nguoi-anh-thuong.mp3"
        };


        private const double BackgroundMusicVolume = 0.24;


        private int currentTrackIndex = 0;

        private int backgroundFailCount = 0;

        private bool backgroundMusicStarted = false;


        // =========================================================
        // HỆ THỐNG
        // =========================================================

        private readonly Random random =
            new Random();


        private readonly DispatcherTimer cursorTimer =
            new DispatcherTimer();


        private readonly DispatcherTimer heartSpawnTimer =
            new DispatcherTimer();


        // =========================================================
        // AUDIO PLAYER
        // =========================================================

        private readonly MediaPlayer backgroundPlayer =
            new MediaPlayer();


        private readonly MediaPlayer dingPlayer =
            new MediaPlayer();


        private readonly MediaPlayer boomPlayer =
            new MediaPlayer();


        // =========================================================
        // TRẠNG THÁI
        // =========================================================

        private bool bootReady = false;

        private bool isTransitioning = false;

        private bool heartOpened = false;

        private bool memoryBusy = false;


        // =========================================================
        // KHỞI TẠO
        // =========================================================

        public MainWindow()
        {
            InitializeComponent();


            cursorTimer.Interval =
                TimeSpan.FromMilliseconds(480);


            cursorTimer.Tick +=
                CursorTimer_Tick;


            heartSpawnTimer.Interval =
                TimeSpan.FromMilliseconds(240);


            heartSpawnTimer.Tick +=
                HeartSpawnTimer_Tick;


            // =====================================================
            // PLAYLIST EVENTS
            // =====================================================

            backgroundPlayer.MediaOpened +=
                BackgroundPlayer_MediaOpened;


            backgroundPlayer.MediaEnded +=
                BackgroundPlayer_MediaEnded;


            backgroundPlayer.MediaFailed +=
                BackgroundPlayer_MediaFailed;
        }


        // =========================================================
        // WINDOW LOADED
        // =========================================================

        private void Window_Loaded(
            object sender,
            RoutedEventArgs e)
        {
            NameInput.Focus();


            LoadEffectSounds();


            StartBackgroundMusic();
        }


        // =========================================================
        // WINDOW CLOSED
        // =========================================================

        private void Window_Closed(
            object? sender,
            EventArgs e)
        {
            cursorTimer.Stop();


            heartSpawnTimer.Stop();


            backgroundPlayer.Stop();

            backgroundPlayer.Close();


            dingPlayer.Stop();

            dingPlayer.Close();


            boomPlayer.Stop();

            boomPlayer.Close();
        }


        // =========================================================
        // ĐƯỜNG DẪN ASSETS
        // =========================================================

        private static string GetAssetPath(
            string fileName)
        {
            return System.IO.Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Assets",
                fileName
            );
        }


        // =========================================================
        // LOAD DING + BOOM
        // =========================================================

        private void LoadEffectSounds()
        {
            LoadEffectSound(
                dingPlayer,
                "dingdong.mp3"
            );


            LoadEffectSound(
                boomPlayer,
                "boom.mp3"
            );
        }


        private void LoadEffectSound(
            MediaPlayer player,
            string fileName)
        {
            try
            {
                string path =
                    GetAssetPath(
                        fileName
                    );


                if (!System.IO.File.Exists(path))
                {
                    return;
                }


                player.Volume =
                    0.95;


                player.Open(
                    new Uri(
                        path,
                        UriKind.Absolute
                    )
                );
            }
            catch
            {
            }
        }


        // =========================================================
        // START PLAYLIST
        // =========================================================

        private void StartBackgroundMusic()
        {
            if (backgroundMusicStarted)
            {
                return;
            }


            backgroundMusicStarted =
                true;


            currentTrackIndex =
                0;


            PlayCurrentBackgroundTrack();
        }


        // =========================================================
        // PLAY TRACK
        // =========================================================

        private void PlayCurrentBackgroundTrack()
        {
            if (backgroundTracks.Length == 0)
            {
                return;
            }


            try
            {
                bool found =
                    false;


                for (int attempt = 0;
                     attempt < backgroundTracks.Length;
                     attempt++)
                {
                    string path =
                        GetAssetPath(
                            backgroundTracks[
                                currentTrackIndex
                            ]
                        );


                    if (System.IO.File.Exists(path))
                    {
                        backgroundPlayer.Stop();


                        backgroundPlayer.Close();


                        backgroundPlayer.Volume =
                            BackgroundMusicVolume;


                        backgroundPlayer.Open(
                            new Uri(
                                path,
                                UriKind.Absolute
                            )
                        );


                        backgroundPlayer.Play();


                        found =
                            true;


                        break;
                    }


                    currentTrackIndex =
                        (
                            currentTrackIndex +
                            1
                        )
                        %
                        backgroundTracks.Length;
                }


                if (!found)
                {
                    backgroundMusicStarted =
                        false;
                }
            }
            catch
            {
            }
        }


        // =========================================================
        // BGM OPENED
        // =========================================================

        private void BackgroundPlayer_MediaOpened(
            object? sender,
            EventArgs e)
        {
            backgroundFailCount =
                0;
        }


        // =========================================================
        // BGM HẾT BÀI -> NEXT
        // =========================================================

        private void BackgroundPlayer_MediaEnded(
            object? sender,
            EventArgs e)
        {
            currentTrackIndex =
                (
                    currentTrackIndex +
                    1
                )
                %
                backgroundTracks.Length;


            PlayCurrentBackgroundTrack();
        }


        // =========================================================
        // BGM ERROR -> SKIP BÀI
        // =========================================================

        private void BackgroundPlayer_MediaFailed(
            object? sender,
            ExceptionEventArgs e)
        {
            backgroundFailCount++;


            if (backgroundFailCount >=
                backgroundTracks.Length)
            {
                backgroundMusicStarted =
                    false;


                return;
            }


            currentTrackIndex =
                (
                    currentTrackIndex +
                    1
                )
                %
                backgroundTracks.Length;


            PlayCurrentBackgroundTrack();
        }


        // =========================================================
        // FADE NHẠC NỀN
        // =========================================================

        private async Task FadeBackgroundVolume(
            double targetVolume,
            int milliseconds)
        {
            if (!backgroundMusicStarted)
            {
                return;
            }


            double startVolume =
                backgroundPlayer.Volume;


            const int steps =
                12;


            int delay =
                Math.Max(
                    1,
                    milliseconds /
                    steps
                );


            for (int i = 1;
                 i <= steps;
                 i++)
            {
                double progress =
                    i /
                    (double)steps;


                backgroundPlayer.Volume =
                    startVolume +
                    (
                        targetVolume -
                        startVolume
                    )
                    *
                    progress;


                await Task.Delay(
                    delay
                );
            }


            backgroundPlayer.Volume =
                targetVolume;
        }


        // =========================================================
        // EFFECT + DUCK BGM
        // =========================================================

        private async Task PlayEffectWithDuck(
            MediaPlayer player,
            double duckVolume,
            int restoreAfterMilliseconds)
        {
            try
            {
                if (backgroundMusicStarted)
                {
                    await FadeBackgroundVolume(
                        duckVolume,
                        140
                    );
                }


                player.Stop();


                player.Position =
                    TimeSpan.Zero;


                player.Volume =
                    0.95;


                player.Play();


                await Task.Delay(
                    restoreAfterMilliseconds
                );


                if (backgroundMusicStarted)
                {
                    await FadeBackgroundVolume(
                        BackgroundMusicVolume,
                        500
                    );
                }
            }
            catch
            {
                if (backgroundMusicStarted)
                {
                    backgroundPlayer.Volume =
                        BackgroundMusicVolume;
                }
            }
        }


        // =========================================================
        // DING DONG
        // =========================================================

        private void PlayDingSound()
        {
            _ =
                PlayEffectWithDuck(
                    dingPlayer,
                    0.05,
                    1200
                );
        }


        // =========================================================
        // BOOM
        // =========================================================

        private void PlayBoomSound()
        {
            _ =
                PlayEffectWithDuck(
                    boomPlayer,
                    0.025,
                    1700
                );
        }


        // =========================================================
        // ESC
        // =========================================================

        private void Window_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }


        // =========================================================
        // LOGIN
        // =========================================================

        private async void LoginButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            await CheckIdentity();
        }


        private async void NameInput_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled =
                    true;


                await CheckIdentity();
            }
        }


        private async Task CheckIdentity()
        {
            if (isTransitioning)
            {
                return;
            }


            string enteredName =
                NormalizeName(
                    NameInput.Text
                );


            if (string.IsNullOrWhiteSpace(
                enteredName))
            {
                LoginStatusText.Foreground =
                    new SolidColorBrush(
                        Color.FromRgb(
                            0xFF,
                            0x31,
                            0x58
                        )
                    );


                LoginStatusText.Text =
                    "Nhập tên của chị vào đi mò.";


                NameInput.Focus();


                return;
            }


            string[] acceptedNames =
            {
                "Bình",
                "Yên Bình",
                "Mai",
                "Tuyết Mai"
            };


            bool isCorrect =
                acceptedNames.Any(
                    name =>
                        string.Equals(
                            enteredName,
                            NormalizeName(name),
                            StringComparison
                                .CurrentCultureIgnoreCase
                        )
                );


            // =====================================================
            // SAI
            // =====================================================

            if (!isCorrect)
            {
                LoginStatusText.Foreground =
                    new SolidColorBrush(
                        Color.FromRgb(
                            0xFF,
                            0x31,
                            0x58
                        )
                    );


                LoginStatusText.Text =
                    "Ôi rất tiếc, người có thể vào được 'choái tym' này không phải chị rồi huhuhuh.\n" +
                    "Mình hỏng cóa duyên ròi huhuhuhu";


                NameInput.SelectAll();


                NameInput.Focus();


                return;
            }


            // =====================================================
            // ĐÚNG
            // =====================================================

            isTransitioning =
                true;


            LoginStatusText.Foreground =
                new SolidColorBrush(
                    Color.FromRgb(
                        0x7C,
                        0xFF,
                        0xB2
                    )
                );


            LoginStatusText.Text =
                "ÔI TÌNH YÊU CỤA EM TỚI ỒI.\n" +
                "ĐI TÌM TÌNH YÊU THOIIII...";


            LoginButton.IsEnabled =
                false;


            NameInput.IsEnabled =
                false;


            // =====================================================
            // DING DONG NGAY KHI LOGIN THÀNH CÔNG
            // =====================================================

            PlayDingSound();


            await Task.Delay(
                1000
            );


            await SwitchScene(
                SceneLogin,
                SceneBoot
            );


            cursorTimer.Start();


            await RunBootSequence();


            isTransitioning =
                false;
        }


        // =========================================================
        // NORMALIZE NAME
        // =========================================================

        private static string NormalizeName(
            string input)
        {
            if (string.IsNullOrWhiteSpace(
                input))
            {
                return string.Empty;
            }


            string[] parts =
                input.Split(
                    new char[]
                    {
                        ' ',
                        '\t',
                        '\r',
                        '\n'
                    },
                    StringSplitOptions
                        .RemoveEmptyEntries
                );


            return string.Join(
                " ",
                parts
            );
        }


        // =========================================================
        // CURSOR
        // =========================================================

        private void CursorTimer_Tick(
            object? sender,
            EventArgs e)
        {
            CursorBlock.Visibility =
                CursorBlock.Visibility ==
                Visibility.Visible

                    ? Visibility.Hidden

                    : Visibility.Visible;
        }


        // =========================================================
        // BOOT
        // =========================================================

        private async Task RunBootSequence()
        {
            string boot =
                "Hế lu chị.\n\n" +

                "Đang khởi tạo...\n" +

                "Đang tải dữ liệu...\n" +

                "Đang kiểm tra...\n\n" +

                "Chờ em mụt chíu nhó.";


            await TypeText(
                BootText,
                boot,
                28
            );


            await Task.Delay(
                850
            );


            await AppendText(
                BootText,

                "\n\nCHƯƠNG TRÌNH ĐÃ SẴN SÀNG.\n\n" +

                "Nhấn để tiếp tục.",

                28
            );


            bootReady =
                true;
        }


        private async void SceneBoot_MouseLeftButtonDown(
            object sender,
            MouseButtonEventArgs e)
        {
            if (!bootReady ||
                isTransitioning)
            {
                return;
            }


            isTransitioning =
                true;


            cursorTimer.Stop();


            await SwitchScene(
                SceneBoot,
                SceneScan
            );


            await RunScanSequence();


            isTransitioning =
                false;
        }


        // =========================================================
        // SCAN
        // =========================================================

        private async Task RunScanSequence()
        {
            int[] steps =
            {
                12,
                37,
                68,
                91,
                100
            };


            ScanProgress.Value =
                0;


            ScanProgress.Foreground =
                new SolidColorBrush(
                    Color.FromRgb(
                        0x7C,
                        0xFF,
                        0xB2
                    )
                );


            foreach (int percent in steps)
            {
                ScanProgress.Value =
                    percent;


                ScanPercentText.Text =
                    percent +
                    "%";


                await Task.Delay(
                    430
                );
            }


            await Task.Delay(
                350
            );


            ScanProgress.Foreground =
                new SolidColorBrush(
                    Color.FromRgb(
                        0xFF,
                        0x31,
                        0x58
                    )
                );


            ScanWarningText.Visibility =
                Visibility.Visible;


            await Task.Delay(
                650
            );


            string processInfo =
                "Tiến trình: NGUOI_AY_LA_AI.exe\n\n" +

                "Mức sử dụng CPU:       45%\n" +

                "Mức sử dụng bộ nhớ:    82%\n" +

                "Chiếm dụng trái tim:  100%";


            await TypeText(
                ProcessText,
                processInfo,
                25
            );


            await Task.Delay(
                1000
            );


            InspectQuestion.Visibility =
                Visibility.Visible;


            InspectButton.Visibility =
                Visibility.Visible;
        }


        // =========================================================
        // INSPECT
        // =========================================================

        private async void InspectButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            InspectButton.IsEnabled =
                false;


            await SwitchScene(
                SceneScan,
                SceneHeart
            );


            StartHeartbeat(
                BigHeartScale
            );


            await Task.Delay(
                100
            );


            for (int i = 0;
                 i < 28;
                 i++)
            {
                SpawnHeart(
                    HeartCanvas,
                    true
                );
            }


            heartSpawnTimer.Start();
        }


        // =========================================================
        // HEARTBEAT
        // =========================================================

        private void StartHeartbeat(
            ScaleTransform scale)
        {
            DoubleAnimationUsingKeyFrames animation =
                new DoubleAnimationUsingKeyFrames
                {
                    RepeatBehavior =
                        RepeatBehavior.Forever
                };


            animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    1.00,
                    KeyTime.FromTimeSpan(
                        TimeSpan.FromMilliseconds(
                            0
                        )
                    )
                )
            );


            animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    1.15,
                    KeyTime.FromTimeSpan(
                        TimeSpan.FromMilliseconds(
                            180
                        )
                    )
                )
            );


            animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    1.00,
                    KeyTime.FromTimeSpan(
                        TimeSpan.FromMilliseconds(
                            360
                        )
                    )
                )
            );


            animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    1.10,
                    KeyTime.FromTimeSpan(
                        TimeSpan.FromMilliseconds(
                            500
                        )
                    )
                )
            );


            animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    1.00,
                    KeyTime.FromTimeSpan(
                        TimeSpan.FromMilliseconds(
                            680
                        )
                    )
                )
            );


            animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    1.00,
                    KeyTime.FromTimeSpan(
                        TimeSpan.FromMilliseconds(
                            1150
                        )
                    )
                )
            );


            scale.BeginAnimation(
                ScaleTransform
                    .ScaleXProperty,
                animation
            );


            scale.BeginAnimation(
                ScaleTransform
                    .ScaleYProperty,
                animation
            );
        }


        // =========================================================
        // HEART TIMER
        // =========================================================

        private void HeartSpawnTimer_Tick(
            object? sender,
            EventArgs e)
        {
            if (SceneHeart.Visibility ==
                Visibility.Visible)
            {
                SpawnHeart(
                    HeartCanvas,
                    true
                );
            }
        }


        // =========================================================
        // HEART PARTICLES
        // =========================================================

        private void SpawnHeart(
            Canvas canvas,
            bool aroundCenter)
        {
            double width =
                Math.Max(
                    canvas.ActualWidth,
                    ActualWidth
                );


            double height =
                Math.Max(
                    canvas.ActualHeight,
                    ActualHeight
                );


            TextBlock heart =
                new TextBlock
                {
                    Text =
                        "❤",

                    FontFamily =
                        new FontFamily(
                            "Segoe UI Symbol"
                        ),

                    FontSize =
                        random.Next(
                            15,
                            39
                        ),

                    Foreground =
                        new SolidColorBrush(
                            Color.FromRgb(
                                0xFF,
                                0x31,
                                0x58
                            )
                        ),

                    Opacity =
                        0.25 +
                        random.NextDouble()
                        *
                        0.6
                };


            canvas.Children.Add(
                heart
            );


            double x;

            double y;


            if (aroundCenter)
            {
                x =
                    width /
                    2 +
                    random.Next(
                        -350,
                        351
                    );


                y =
                    height /
                    2 +
                    random.Next(
                        -80,
                        260
                    );
            }
            else
            {
                x =
                    random.NextDouble()
                    *
                    width;


                y =
                    height +
                    random.Next(
                        0,
                        100
                    );
            }


            Canvas.SetLeft(
                heart,
                x
            );


            Canvas.SetTop(
                heart,
                y
            );


            double seconds =
                3 +
                random.NextDouble()
                *
                3;


            DoubleAnimation moveUp =
                new DoubleAnimation
                {
                    From =
                        y,

                    To =
                        -100,

                    Duration =
                        TimeSpan.FromSeconds(
                            seconds
                        )
                };


            DoubleAnimation drift =
                new DoubleAnimation
                {
                    From =
                        x,

                    To =
                        x +
                        random.Next(
                            -100,
                            101
                        ),

                    Duration =
                        TimeSpan.FromSeconds(
                            seconds
                        )
                };


            DoubleAnimation fade =
                new DoubleAnimation
                {
                    From =
                        heart.Opacity,

                    To =
                        0,

                    Duration =
                        TimeSpan.FromSeconds(
                            seconds
                        )
                };


            moveUp.Completed +=
                (_, _) =>
                {
                    canvas.Children.Remove(
                        heart
                    );
                };


            heart.BeginAnimation(
                Canvas.TopProperty,
                moveUp
            );


            heart.BeginAnimation(
                Canvas.LeftProperty,
                drift
            );


            heart.BeginAnimation(
                UIElement.OpacityProperty,
                fade
            );
        }


        // =========================================================
        // BIG HEART
        // =========================================================

        private async void BigHeart_MouseLeftButtonDown(
            object sender,
            MouseButtonEventArgs e)
        {
            if (heartOpened)
            {
                return;
            }


            heartOpened =
                true;


            heartSpawnTimer.Stop();


            for (int i = 0;
                 i < 45;
                 i++)
            {
                SpawnHeart(
                    HeartCanvas,
                    true
                );
            }


            await Task.Delay(
                500
            );


            await SwitchScene(
                SceneHeart,
                SceneMemory
            );
        }


        // =========================================================
        // MEMORY
        // =========================================================

        private async void MemoryButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (memoryBusy)
            {
                return;
            }


            if (sender is not Button button)
            {
                return;
            }


            if (!button.IsEnabled)
            {
                return;
            }


            memoryBusy =
                true;


            button.IsEnabled =
                false;


            string memory;


            switch (
                button.Tag?.ToString()
            )
            {
                case "1":

                    memory =
                        First;

                    break;


                case "2":

                    memory =
                        Second;

                    break;


                default:

                    memory =
                        Last;

                    break;
            }


            await TypeText(
                MemoryText,

                button.Content +
                "\n\n" +
                memory,

                22
            );


            if (
                button.Tag?.ToString()
                ==
                "1"
            )
            {
                SecondMemoryButton.IsEnabled =
                    true;
            }


            if (
                button.Tag?.ToString()
                ==
                "2"
            )
            {
                LastMemoryButton.IsEnabled =
                    true;
            }


            memoryBusy =
                false;


            if (
                button.Tag?.ToString()
                ==
                "3"
            )
            {
                await Task.Delay(
                    350
                );


                MemoryContinueButton.Visibility =
                    Visibility.Visible;


                await AnimateOpacity(
                    MemoryContinueButton,
                    0,
                    1,
                    500
                );
            }
        }


        // =========================================================
        // CONTINUE
        // =========================================================

        private async void MemoryContinueButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (isTransitioning)
            {
                return;
            }


            isTransitioning =
                true;


            MemoryContinueButton.IsEnabled =
                false;


            await AnimateOpacity(
                MemoryContinueButton,
                1,
                0,
                250
            );


            MemoryContinueButton.Visibility =
                Visibility.Collapsed;


            AnalysisCompleteText.Visibility =
                Visibility.Visible;


            await AnimateOpacity(
                AnalysisCompleteText,
                0,
                1,
                450
            );


            await Task.Delay(
                850
            );


            await SwitchScene(
                SceneMemory,
                SceneDecrypt
            );


            await RunDecryptSequence();


            isTransitioning =
                false;
        }


        // =========================================================
        // DECRYPT
        // =========================================================

        private async Task RunDecryptSequence()
        {
            await TypeText(
                DecryptTerminal,

                "Đang tìm kiếm...",

                32
            );


            await Task.Delay(
                650
            );


            await AppendText(
                DecryptTerminal,

                "\n\nĐã tìm thấy 1 kết quả phù hợp.",

                32
            );


            await Task.Delay(
                700
            );


            await AppendText(
                DecryptTerminal,

                "\n\nĐang giải mã...",

                32
            );


            DecryptProgress.Visibility =
                Visibility.Visible;


            await Task.Delay(
                350
            );


            for (
                int percent = 0;
                percent <= 100;
                percent += 5
            )
            {
                DecryptProgress.Value =
                    percent;


                int blocks =
                    percent /
                    5;


                string bar =
                    new string(
                        '█',
                        blocks
                    );


                string empty =
                    new string(
                        '░',
                        20 -
                        blocks
                    );


                DecryptBarText.Text =
                    bar +
                    empty +
                    " " +
                    percent +
                    "%";


                await Task.Delay(
                    55
                );
            }


            await Task.Delay(
                650
            );


            await AppendText(
                DecryptTerminal,

                "\n\nĐÃ XÁC ĐỊNH NGUYÊN NHÂN:",

                32
            );


            await Task.Delay(
                500
            );


            SecretButton.Visibility =
                Visibility.Visible;
        }


        // =========================================================
        // SECRET
        // =========================================================

        private async void SecretButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            SecretButton.IsEnabled =
                false;


            await AnimateOpacity(
                SceneDecrypt,
                1,
                0,
                300
            );


            SceneDecrypt.Visibility =
                Visibility.Collapsed;


            SceneFinal.Visibility =
                Visibility.Visible;


            SceneFinal.Opacity =
                1;


            FinalScrollViewer.ScrollToTop();


            await Task.Delay(
                550
            );


            FinalContent.Visibility =
                Visibility.Visible;


            await AnimateOpacity(
                FinalContent,
                0,
                1,
                500
            );


            BuildStamp.Visibility =
                Visibility.Visible;


            await RunFinalSequence();
        }


        // =========================================================
        // FINAL
        // =========================================================

        private async Task RunFinalSequence()
        {
            StartHeartbeat(
                FinalHeartScale
            );


            await TypeText(
                FinalIntroText,

                "Thật ra...\n\n" +

                "em đã muốn nói điều này\n" +

                "từ khá lâu rồi.",

                40
            );


            await Task.Delay(
                950
            );


            await TypeText(
                FinalLeadText,

                "Người làm 'bộ nhớ' của em\n" +

                "thường xuyên bị 'tràn' là...",

                42
            );


            await Task.Delay(
                1200
            );


            string displayName =
                string.IsNullOrWhiteSpace(
                    HerName
                )

                    ? "[TÊN NGƯỜI ẤY]"

                    : HerName;


            HerNameText.Text =
                displayName;


            HerNameText.Visibility =
                Visibility.Visible;


            await AnimateOpacity(
                HerNameText,
                0,
                1,
                700
            );


            await Task.Delay(
                1300
            );


            await TypeText(
                FinalLoveText,
                FinalMessageBeforeBoom,
                35
            );


            await Task.Delay(
                1000
            );


            await AppendText(
                FinalLoveText,
                "\n\n",
                15
            );


            // =====================================================
            // BOOM + NHẠC NỀN TỰ HẠ
            // =====================================================

            PlayBoomSound();


            await AppendText(
                FinalLoveText,
                "💥 ĐÙNG! 💥",
                55
            );


            await Task.Delay(
                1000
            );


            await AppendText(
                FinalLoveText,
                FinalMessageAfterBoom,
                45
            );


            await Task.Delay(
                1000
            );


            await TypeText(
                FinalQuestionText,

                "Vậy... chị có muốn cho em một cơ hội không? ❤",

                38
            );


            await Task.Delay(
                500
            );


            FinalButtons.Visibility =
                Visibility.Visible;


            await Task.Delay(
                150
            );


            FinalScrollViewer.ScrollToEnd();
        }


        // =========================================================
        // YES
        // =========================================================

        private async void YesButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (!FinalButtons.IsEnabled)
            {
                return;
            }


            FinalButtons.IsEnabled =
                false;


            FinalStatusText.Text =
                "OMG, SHE SAID YESSSSS ❤";


            FinalStatusText.Foreground =
                new SolidColorBrush(
                    Color.FromRgb(
                        0xFF,
                        0x31,
                        0x58
                    )
                );


            FinalScrollViewer.ScrollToEnd();


            for (
                int i = 0;
                i < 75;
                i++
            )
            {
                SpawnHeart(
                    FinalHeartCanvas,
                    false
                );


                if (
                    i %
                    10 ==
                    0
                )
                {
                    await Task.Delay(
                        20
                    );
                }
            }


            await Task.Delay(
                1200
            );


            await ShowDeveloperNote();
        }


        // =========================================================
        // NO
        // =========================================================

        private async void ThinkButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (!FinalButtons.IsEnabled)
            {
                return;
            }


            FinalButtons.IsEnabled =
                false;


            FinalStatusText.Text =
                "Không sao đâu :>\n\n" +

                "Em vẫn trân trọng chị và câu trả lời này. ❤";


            FinalStatusText.Foreground =
                new SolidColorBrush(
                    Color.FromRgb(
                        0x7C,
                        0xFF,
                        0xB2
                    )
                );


            FinalScrollViewer.ScrollToEnd();


            await Task.Delay(
                1200
            );


            await ShowDeveloperNote();
        }


        // =========================================================
        // NOTE
        // =========================================================

        private async Task ShowDeveloperNote()
        {
            DeveloperNoteOverlay.Visibility =
                Visibility.Visible;


            await AnimateOpacity(
                DeveloperNoteOverlay,
                0,
                1,
                500
            );
        }


        private async void CloseDeveloperNote_Click(
            object sender,
            RoutedEventArgs e)
        {
            await AnimateOpacity(
                DeveloperNoteOverlay,
                1,
                0,
                300
            );


            DeveloperNoteOverlay.Visibility =
                Visibility.Collapsed;
        }


        // =========================================================
        // TYPEWRITER
        // =========================================================

        private async Task TypeText(
            TextBlock textBlock,
            string text,
            int delay = 35)
        {
            textBlock.Text =
                "";


            foreach (
                char character
                in text
            )
            {
                textBlock.Text +=
                    character;


                await Task.Delay(
                    delay
                );
            }
        }


        private async Task AppendText(
            TextBlock textBlock,
            string text,
            int delay = 35)
        {
            foreach (
                char character
                in text
            )
            {
                textBlock.Text +=
                    character;


                await Task.Delay(
                    delay
                );
            }
        }


        // =========================================================
        // SWITCH SCENE
        // =========================================================

        private async Task SwitchScene(
            UIElement oldScene,
            UIElement newScene)
        {
            await AnimateOpacity(
                oldScene,
                1,
                0,
                320
            );


            oldScene.Visibility =
                Visibility.Collapsed;


            newScene.Visibility =
                Visibility.Visible;


            await AnimateOpacity(
                newScene,
                0,
                1,
                420
            );
        }


        // =========================================================
        // OPACITY
        // =========================================================

        private Task AnimateOpacity(
            UIElement element,
            double from,
            double to,
            int milliseconds)
        {
            TaskCompletionSource<bool> source =
                new TaskCompletionSource<bool>();


            DoubleAnimation animation =
                new DoubleAnimation
                {
                    From =
                        from,

                    To =
                        to,

                    Duration =
                        TimeSpan.FromMilliseconds(
                            milliseconds
                        )
                };


            animation.Completed +=
                (_, _) =>
                {
                    element.BeginAnimation(
                        UIElement.OpacityProperty,
                        null
                    );


                    element.Opacity =
                        to;


                    source.TrySetResult(
                        true
                    );
                };


            element.Opacity =
                from;


            element.BeginAnimation(
                UIElement.OpacityProperty,
                animation
            );


            return source.Task;
        }
    }
}