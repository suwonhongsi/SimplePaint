using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle } // 사용할 도형 타입
        private Bitmap canvasBitmap; // 실제 그림이 저장되는 비트맵
        private Graphics canvasGraphics; // 비트맵 위에 그리기 위한객체
        private bool isDrawing = false; // 현재 드래그 중인지 여부
        private Point startPoint; // 드래그 시작점
        private Point endPoint; // 드래그 끝점
        private ToolType currentTool = ToolType.Line; // 현재 선택된 도형
        private Color currentColor = Color.Black; // 현재 색상
        private int currentLineWidth = 2; // 현재 선 두께

        public Form1()
        {
            InitializeComponent();

            // 캔버스 초기화
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White); // 캔버스를 흰색으로 초기화

            picCanvas.Image = canvasBitmap; // 그린 그림을 화면(PictureBox)에표시

            // 마우스 이벤트 연결
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;

            // picCanvas가 다시 그려질 때 PicCanvas_Paint 함수를 실행하도록 연결
            picCanvas.Paint += picCanvas_Paint;

            // 도형 선택 버튼 이벤트 연결
            btnline.Click += btnline_Click;
            btnRectangle.Click += btnRectangle_Click;
            btnCircle.Click += btnCircle_Click;

            // 색상 콤보박스 이벤트 연결
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex = 1; // 기본값

            // 선 두께 트랙바 이벤트 연결
            trbLineWidth.Minimum = 1; // 최소값
            trbLineWidth.Maximum = 10; // 최대값
            trbLineWidth.Value = 5;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;

        }

        private void Button_open_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true; // 드래그 시작
            startPoint = e.Location; // 시작점 저장
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return; // 그림 그리기와 상관 없는 마우스 움직임은무시

            endPoint = e.Location; // 현재 위치 갱신

            // picCanvas를 다시 그려라 (Paint 이벤트를 발생시킨다)
            picCanvas.Invalidate(); // 화면 다시 그리기 (미리보기) 
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return; // 그림 그리기와 상관 없는 마우스 움직임은무시

            isDrawing = false; // 드래그 종료
            endPoint = e.Location;

            // 실제 비트맵에 도형 그리기 (확정)
            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }
            picCanvas.Invalidate(); // 다시 그려서 결과 반영, Paint 이벤트 발생
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!isDrawing) return;

            // 점선 펜 (미리보기용)
            using (Pen previewPen = new Pen(currentColor, currentLineWidth))
            {
                previewPen.DashStyle = DashStyle.Dash;
                DrawShape(e.Graphics, previewPen, startPoint, endPoint);
            }
        }

        private void btnline_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0: // Black 검정
                    currentColor = Color.Black;
                    break;
                case 1: // Red 빨강
                    currentColor = Color.Red;
                    break;
                case 2: // Blue 파랑
                    currentColor = Color.Blue;
                    break;
                case 3: // Green 녹색
                    currentColor = Color.Green;
                    break;
                default:
                    currentColor = Color.Black;
                    break;
            }
        }

        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }

        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Rectangle rect = GetRectangle(p1, p2);
            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, p1, p2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
            Math.Min(p1.X, p2.X),
            Math.Min(p1.Y, p2.Y),
            Math.Abs(p1.X - p2.X),
            Math.Abs(p1.Y - p2.Y)
            );
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // 1. SaveFileDialog 생성 및 설정
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "그림 저장하기";
                // 파일 확장자 필터 설정 (png, jpg, bmp)
                saveFileDialog.Filter = "PNG 파일 (*.png)|*.png|JPEG 파일 (*.jpg)|*.jpg|Bitmap 파일 (*.bmp)|*.bmp";
                saveFileDialog.DefaultExt = "png"; // 기본 확장자

                // 2. 대화상자를 띄우고 사용자가 '저장'을 눌렀을 때만 실행
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 3. 선택한 파일의 확장자에 따라 포맷 결정
                        ImageFormat format = ImageFormat.Png; // 기본값

                        switch (saveFileDialog.FilterIndex)
                        {
                            case 2: // JPEG 파일 (*.jpg)
                                format = ImageFormat.Jpeg;
                                break;
                            case 3: // Bitmap 파일 (*.bmp)
                                format = ImageFormat.Bmp;
                                break;
                            default: // 1번 혹은 기타 (PNG)
                                format = ImageFormat.Png;
                                break;
                        }

                        // 4. 비트맵을 지정된 경로와 포맷으로 저장
                        canvasBitmap.Save(saveFileDialog.FileName, format);

                        MessageBox.Show("그림이 성공적으로 저장되었습니다!", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("저장 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
