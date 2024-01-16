# Hướng Dẫn Chạy Ứng Dụng Xổ Số Rooster

Ứng dụng Xổ Số Rooster là một ứng dụng đơn giản để tham gia trò chơi xổ số và kiểm tra kết quả. Dưới đây là các bước để chạy ứng dụng này trên máy tính của bạn.

## Yêu Cầu

Trước khi bạn bắt đầu, bạn cần cài đặt các yêu cầu sau:

## Cài Đặt

   
git clone https:[/github.com/your-username/RoosterLotteryApp.git](https://github.com/huyphutran/Rooster.Lottery)

Mở File Explore chọn một Ổ đĩa cần lưu dự án sau khi cận ổ đĩa và tạo một thư mục lưu dự án ( Chuột phải -> new file -> folder)
khi tạo xong thư mục chuột phải chọn Open Git Bash Here
và tiến hành dán link được cung cấp theo HTTP hoặc SSH key để clone dự án về máy:
SSH: git@github.com:huyphutran/Rooster.Lottery.git
HTTTP: https://github.com/huyphutran/Rooster.Lottery.git
## Chạy ứng dụng

sau khi clone về máy tiến hành vào Visual Studio tiến hành mở dự án và chạy:

Khởi chạy Server Site trước (Rooster.Lottery) sau khi chạy Server Site sẽ hiển thị một trang webite có [localhost](https://localhost:7194/) hoặc tùy thuộc vào máy bạn (Lưu ý không được tắt Website vì khi Tắt bên Client-Site sẽ không nhận được dữ liệu từ phía Server)

chạy dự án ở Client Site (WinForm.Rooster.Lottery) Khi chạy thành công Form sẽ hiện lên.
## Sử Dụng Ứng Dụng

### 1. Chào Mừng và Đăng Ký / Đăng Nhập:

- Khi WinForm xuất hiện, người dùng sẽ được chào mừng đến ứng dụng và yêu cầu thực hiện một trong những hành động sau:
  - Đăng nhập vào tài khoản của mình nếu đã có.
  - Đăng ký tài khoản nếu chưa có.
- Để đăng ký, người dùng cung cấp thông tin như UserName, Số Điện Thoại và Ngày Sinh để đăng ký.
- Sau khi hệ thống kiểm tra thông tin hợp lệ, người dùng sẽ chuyển đến Form Đăng Nhập.

### 2. Đặt Vé Xổ Số:

- Sau khi đăng nhập thành công, người dùng sẽ chuyển đến Form Đặt Vé Xổ Số.
- Người dùng chọn các tùy chọn đặt vé và kiểm tra thời gian đặt vé.
- Mô tả chi tiết:
  - **Case:** Người dùng được yêu cầu chọn kết quả trong một khung chọn và chọn thời gian hợp lệ.
  - **Lưu Ý:** Trong khung chọn thời gian, người dùng chỉ có thể chọn giờ kế tiếp và không thể chọn giờ hiện tại hoặc quá khứ.
- Sau khi chọn xong, người dùng nhấn nút "Add Lottery".
- Nếu đặt vé thành công, người dùng sẽ nhận được một thông báo xác nhận.

### 3. Xem Lịch Sử Đặt Vé:

- Người dùng có thể kiểm tra lịch sử đặt vé của họ bằng cách nhấn nút "View Lottery History".
- Họ sẽ được chuyển đến một Form hiển thị danh sách các vé đã đặt.

### 4. Kiểm Tra Kết Quả Xổ Số:

- Nếu người dùng muốn kiểm tra kết quả xổ số, họ có thể nhấn nút "Lottery Result".
- Ứng dụng sẽ hiển thị kết quả xổ số gần nhất.
### Ghi Chú : 
Tính Năng cộng thêm :Kiểm tra kết quả xổ số trong thời gian cụ thế
Mô tả : người dùng sẽ nhấn nút View Lottery Result thì họ sẽ có thể xem được kết quả xổ số ở thời gian gần nhất
(Note: vì do do business rule bắt user phải chờ 1 tiếng mới kiểm tra được kết quả xổ số hơi bất tiện cho việc test kết quả nên chức năng này chỉ sẽ lấy thời gian hiện tạo để tạo ra kết quả xổ số) 


## Ghi Chú

Ứng dụng này chỉ để mục đích tham khảo và học tập. Không sử dụng thông tin cá nhân thực tế trong ứng dụng.
