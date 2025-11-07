using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Net.WebRequestMethods;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        //static string a = 
        public static string? Example = null;// Properties.Resources.새_텍스트_문서;// = "자바스크립트에서 변수 x를 정의해보자. 어떤 키워드를 사용하여 변수를 정의할 수 있을까? := let x;\r\nconst 키워드는 무엇을 정의하기 위해 사용? := 상수\r\n숫자를 가지는 JS의 데이터 타입은? := 수치형\r\n텍스트 데이터를 가지는 JS의 데이터 타입은? := 문자열\r\ntrue와 false 값을 가지는 JS의 데이터 타입은? := 부울형\r\n빈 값 또는 정의되지 않은 값을 가지는 JS의 데이터 타입은? := undefined\r\n객체를 가지는 JS의 데이터 타입은? := 객체형\r\n문자열들을 대문자로 변경 하는 메서드는? := toUpperCase()\r\n템플릿 리터럴 문자열을 사용하는 기호는? := $\r\n${변수명}과 같은 형식으로 변수를 삽입하는 방법은? := 템플릿 리터럴\r\n객체형을 선언할때 사용하는 기호는 ? := {}\r\n값과 타입이 모두 같은지 비교하는 연산자는? := ===\r\n값이나 타입이 다른지 비교하는 연산자는? := !==\r\n값이 같은지 비교하는 연산자는? := ==\r\nc에서 scanf와 같이 입력을 받는 함수는? := prompt()\r\nconsole에 값을 출력하는 함수는? := console.log()\r\nboolean 값을 반환하는 확인 함수는? := confirm()\r\nhtml 정보를 가지고 있는\t 객체는? := document\r\nhtml 요소를 id로 선택하는 메서드는? := getElementById()\r\n요소의 내용, 요소의 contents에 접근하는 속성은? := innerHTML\r\nhtml문서에 쓸때 사용하는 메소드 := document.write();\r\nform요소의 값, 즉, 사용자의 입력값에 접근하는 속성 := value\r\n현재 시각을 가져오는 객체 := Date\r\n현재 시간을 가져오려면 ? := new Date().getHours()\r\n정해진 횟수만큼\t반복하는 반복문 := for\r\n조건이 참인 동안 반복하는 반복문 := while\r\n함수를 정의하는 키워드 := function\r\n자바스크립트는 웹페이지의 _____을 제어하기 위해 사용된다. := 동작\r\n자바스크립트는 변수의 타입을 ____으로 결정한다. := 동적\r\n자바스크립트는 _____ 위에서 실행된다. := 브라우저\r\n자바스크립트는 ________ 언어이다. := 인터프리터\r\n자바스크립트의 특징중 하나인 __________덕분에 변수가 동적으로 정의된다. := 동적타이핑\r\n자바스크립트는 HTML 컨텐츠를 _____으로 변경할 수 있다. := 동적";
        const int ex_count = 20;
        //"CSS가 하는 역할은? := 스타일\r\nHTML 파일에서 CSS는 어떤 태그 내부에 기술하나요? := style\r\n선택자란 무엇인가? := 요소\r\nCSS의 선택자가 jQuery에서도 사용되는가? := 예\r\n가장 많이 사용되는 선택자는 몇 가지인가? := 6\r\n타입 선택자(type selector)는 무엇을 사용하나요? := 태그\r\n전체 선택자(universal selector)는 어떻게 표시하나요? := *\r\n아이디 선택자(id selector)는 어떤 요소를 선택하나요? := id\r\n클래스 선택자(class selector)는 어떤 요소를 선택하나요? := class\r\n선택자 그룹은 어떻게 나열하나요? := ,\r\n후손 선택자(s1 s2)는 어떤 요소를 선택하나요? := 후손\r\n자식 선택자(s1 > s2)는 어떤 요소를 선택하나요? := 자식\r\n의사 클래스(pseudo-class)란 무엇인가? := 상태\r\na:link 의사 클래스는 어떤 링크를 나타내나요? := 링크\r\np:hover 의사 클래스는 어떤 동작을 유발하나요? := 마우스\r\np::before는 무엇을 추가하나요? := 내용\r\n아이디 선택자와 클래스 선택자의 차이점은 무엇인가? := 고유\r\n전체 선택자는 어떻게 만들어내는가? := *\r\n외부 CSS 파일을 HTML에서 불러들이는 문장은 무엇인가? := link\r\n내부, 외부, 인라인 CSS 중 가장 우선순위가 높은 것은 무엇인가? := 인라인\r\n스타일의 상속은 어떤 방식으로 이루어지나요? := 부모\r\n요소의 스타일이 요소로 어떻게 상속되나요? := 자식\r\n흰색을 나타내는 16진수 리터럴은 무엇인가? := #FFFFFF\r\n요소의 배경색을 녹색으로 지정하는 CSS 문장은 무엇인가? := green\r\n폰트 크기를 어떻게 지정할 수 있나요? := size\r\n요소의 폰트를 \"굴림체\"로 지정하는 CSS 문장은 무엇인가? := gulim\r\n요소의 글자를 모두 대문자로 바꾸는 CSS 문장은 무엇인가? := uppercase\r\n요소의 글자색을 \"파랑색\"으로 지정하는 CSS 문장은 무엇인가? := blue\r\ntext-align 속성은 무엇을 조절하나요? := 정렬\r\ntext-decoration 속성의 가능한 값 중 하나는 무엇인가? := underline\r\ntext-transform 속성의 값으로 \"uppercase\"는 무엇을 의미하나요? := 대문자\r\ntext-shadow 속성은 무엇을 추가하나요? := 그림자\r\nword-wrap: break-word;는 어떤 기능을 하나요? := 줄바꿈\r\ncolumn-count 속성은 무엇을 설정하나요? := 열수\r\nCSS의 기본 문법 구조는 무엇인가? := 선택자\r\nCSS 주석은 어떻게 작성하나요? := /*\r\nCSS가 없다면 어떤 문제가 발생하나요? := 스타일\r\nCSS를 외부 파일에 저장하면 어떤 이점이 있나요? := 공유\r\n16진수 코드로 색상을 나타낼 때 어떤 값을 사용하나요? := #\r\nRGB 값으로 색상을 표시할 때 어떤 형식을 따르나요? := rgb\r\nfont-size 속성은 어떤 단위로 설정할 수 있나요? := px\r\nfont-weight 속성의 값으로 \"bold\"는 무엇을 의미하나요? := 굵게\r\nfont-style 속성의 값으로 \"italic\"은 무엇을 의미하나요? := 기울임\r\n텍스트 정렬에서 \"justify\"는 어떤 스타일을 적용하나요? := 양쪽\r\n다중 컬럼 레이아웃에서 column-gap은 무엇을 조절하나요? := 간격\r\nCSS를 이용하여 제목의 글자 크기를 20px로 지정하려면 어떻게 하나요? := 20px\r\n배경색을 aqua로 설정하려면 어떤 CSS 속성을 사용하나요? := background:=color\r\nCSS에서 color 속성을 사용하여 텍스트를 빨간색으로 만들려면 어떻게 하나요? := red\r\n클래스가 \"type1\"인 요소의 배경색을 노란색으로 지정하려면 어떻게 하나요? := yellow\r\nID가 \"special\"인 요소의 글자색을 파란색으로 지정하려면 어떻게 하나요? := blue";
        public string?[] args = null;//Example.Split("\r\n", StringSplitOptions.None);
        public List<string> list = new List<string>();
        public int counter = 0;
        public int idx = 0;
        public bool[] correct;
        public List<string> correctList = new List<string>();
        public List<string> answer = new List<string>();
        public static bool isReading = false;

        public static bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            panel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Example);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = (++counter).ToString();
            if (counter == 60)
            {
                timer1.Stop();
                MessageBox.Show("시간 종료");
            }
        }
        private void StartEX()
        {
            if(!isReading &&( args == null))
            {
                MessageBox.Show("문제 파일을 선택해주세요.");
                return;
            }
            isRunning = true;
            idx = 0;
            correct = null;
            correct = new bool[ex_count];
            list.Clear();
            correctList.Clear();
            answer.Clear();
            textBox1.Text = "";
            counter = 0;
            panel.Visible = true;
            timer1.Start();
            Random random = new Random();
           var count = (args.Length < ex_count) ? args.Length : ex_count;
            while (list.Count != count)
            {
                string[] input = args[random.Next(0, args.Length)].Split(":=", StringSplitOptions.None);
                if (list.Contains(input[0]))
                {
                    continue;
                }
                list.Add(input[0]);
                correctList.Add(input[1].Trim());
            }

            label1.Text = list[idx];



        }
        private void Start_Click(object sender, EventArgs e)
        {
            StartEX();
        }
        private void show()
        {
            listBox1.Items.Clear();
            foreach (var i in answer)
                listBox1.Items.Add(i);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(!isReading || !isRunning)
            {
                MessageBox.Show("문제 파일을 선택해주세요.");
                return;
            }
            button1.Enabled = true;
            //if (idx == 10) { MessageBox.Show("끝"); return; }
            correct[idx] = textBox1.Text.Trim() == correctList[idx];
            if (answer.Count < idx + 1)
                answer.Add((idx + 1).ToString() + "번 문제 : " + label1.Text + (correct[idx] ? "O    " : "X    "));
            answer[idx] += ("입력: " + textBox1.Text.Trim() + "  정답 : " + correctList[idx]);
            if (idx == ex_count) { MessageBox.Show("끝"); return; }
            label1.Text = list[++idx];
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                MessageBox.Show("시험을 시작해주세요.");
                return;
            }
            if (idx == 0) { button1.Enabled = false; return; }
            textBox1.Text = "";
            label1.Text = list[--idx];
            answer[idx] = "";
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void SelectFile(string FileSrc, string FileType)
        {
            FileInfo Filename;

            OpenFileDialog FileOpenDialog = new OpenFileDialog();

            FileOpenDialog.InitialDirectory = FileSrc;
            FileOpenDialog.Filter = "text Files | *.txt";

            FileOpenDialog.CheckFileExists = true;
            FileOpenDialog.CheckPathExists = true;

            if (FileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                Filename = new FileInfo(FileOpenDialog.FileName);

                using (var sr = new StreamReader(Filename.FullName,System.Text.Encoding.UTF8))
                {
                    Example = sr.ReadToEnd();
                    sr.Close();
                }
               
  

                args = Example.Split("\n", StringSplitOptions.None);
                args = args.Select(s => s.Trim('\r')).ToArray();

                MessageBox.Show("파일이 성공적으로 로드되었습니다. 총 " + args.Length.ToString() + "개의 문제가 있습니다.");

                //MessageBox.Show("Selected File : " + Filename.FullName);



            }
            isReading = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //System.Environment.CurrentDirectory
            SelectFile(System.Windows.Forms.Application.StartupPath, "All Files");
            
        }
    }
}
