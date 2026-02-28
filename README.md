- Hệ thống quản lý ga xe khách (WinForms)

Ứng dụng desktop giúp quản lý toàn bộ hoạt động tại ga xe khách: quản lý tuyến đường – bến xe – xe – lịch chạy, đặt/hủy vé, theo dõi trạng thái ghế và thống kê doanh thu.  
Hệ thống được xây dựng trên nền WinForms với giao diện hiện đại (Guna UI2) và kiến trúc phân tầng, sử dụng Entity Framework để làm việc với cơ sở dữ liệu SQL Server.

- Mục tiêu dự án

Xây dựng một ứng dụng quản lý vận hành ga xe khách thực tế (bus station management).  
Áp dụng kiến trúc phân tầng (UI – Business Logic – Data Access – DTO) vào dự án WinForms.  
Thực hành sử dụng Entity Framework, LINQ để thao tác dữ liệu và ánh xạ quan hệ phức tạp.  
Thiết kế giao diện người dùng thân thiện, dễ sử dụng cho nhân viên bán vé và admin.  
Xây dựng các màn hình thống kê doanh thu trực quan bằng biểu đồ.

- Chức năng chính

Đăng nhập, phân quyền người dùng (Admin, Staff).  
Quản lý bến xe (Station): thêm/sửa/xóa, tra cứu thông tin bến.  
Quản lý tuyến đường và chặng (Route, Route_SubRoute): cấu hình tuyến, khoảng cách, bến đi/bến đến.  
Quản lý xe khách (Bus): thông tin xe, biển số, cấu hình số ghế.  
Quản lý ghế (Seat): danh sách ghế theo xe, trạng thái ghế (còn trống/đã đặt).  
Quản lý lịch chạy (Schedule, Schedule_Stop): tạo lịch chạy cho từng tuyến, gán xe, thời gian xuất bến, các điểm dừng.  
Đặt vé (Ticket): chọn tuyến, lịch chạy, trạm đi/trạm đến, chọn ghế, tính giá vé và lưu vé.  
Xem chi tiết vé, in thông tin vé, kiểm tra thông tin hành khách.  
Hủy vé: tìm vé theo mã, hủy vé và cập nhật lại trạng thái ghế.  
Quản lý nhân viên: hồ sơ nhân viên, cập nhật thông tin cá nhân, đổi mật khẩu tài khoản.  
Thống kê và báo cáo doanh thu: doanh thu theo ngày, theo tháng, theo năm; hiển thị bằng biểu đồ.  
Theo dõi lịch sử vị trí xe (Bus_Location_History) để phục vụ tra cứu và quản lý vận hành.

- System Architecture

Hệ thống được tổ chức thành nhiều project tách biệt:

1. UI Layer (`PBL3.UI`)

WinForms (.NET Framework 4.7.2) + Guna.UI2 để xây dựng giao diện hiện đại.  
Các form chính: `LoginForm`, `AdminForm`, `StaffForm`, `StationView`, `RouteView`, `ScheduleView`, `BusView`, `SeatView`, `BookTicket`, `CancelTicket`, `TicketView`, `RevenueView`, `YearRevenueView`, `StaffView`, `AccountDetail`, v.v.  
Vai trò:  
Nhận tương tác từ người dùng (nhân viên/admin).  
Gọi tới tầng Service để thực thi nghiệp vụ (đặt vé, hủy vé, tạo lịch chạy, thống kê…).  
Hiển thị dữ liệu và biểu đồ theo format thân thiện với người dùng.

2. Business Logic Layer (`PBL3.BLL`)

Chứa các lớp Service: `TicketService`, `BusService`, `RouteService`, `Route_SubRouteService`, `ScheduleService`, `StaffService`, `AccountService`, `HistoryService`, v.v.  
Đóng gói toàn bộ logic nghiệp vụ: kiểm tra dữ liệu đầu vào, chuyển đổi Entity ↔ DTO, tính toán doanh thu, xử lý luồng đặt/hủy vé, lấy dữ liệu biểu đồ thống kê.  
Đảm bảo UI không truy cập trực tiếp database mà thông qua Service.

3. Data Access Layer (`PBL3.DAL`)

Sử dụng Entity Framework 6 (DbContext `BusManagement`) để làm việc với SQL Server.  
Chứa các Entity: `Account`, `Admin`, `Staff`, `Bus`, `Station`, `Route`, `Route_SubRoute`, `Schedule`, `Schedule_Stop`, `SEAT`, `Ticket`, `Bus_Location_History`, v.v.  
Tổ chức theo Repository Pattern: `TicketRepository`, `BusRepository`, `StationRepository`, `ScheduleRepository`, `ScheduleStopRepository`, `SeatRepository`, `Route_SubRouteRepository`, `AccountRepository`, v.v.  
Định nghĩa quan hệ giữa các bảng và ràng buộc toàn vẹn (quan hệ 1-n, n-n, cascade delete…) trong `OnModelCreating`.

4. DTO Layer (`PBL3.DTO`)

Chứa các lớp DTO: `TicketDTO`, `BusDTO`, `StationDTO`, `RouteDTO`, `Route_SubRouteDTO`, `ScheduleDTO`, `ScheduleStopDTO`, `StaffDTO`, `AccountDTO`, `BusTicketDTO`, `HistoryDTO`, `Session`, v.v.  
Vai trò:  
Tách biệt dữ liệu trao đổi giữa UI và BLL khỏi Entity của database.  
Giảm coupling, giúp dễ dàng bind dữ liệu lên UI và bảo mật/ẩn bớt chi tiết DB.

Thiết kế này giúp:

Tách riêng giao diện, nghiệp vụ và truy cập dữ liệu, dễ bảo trì và mở rộng.  
Giảm phụ thuộc giữa các tầng, tận dụng lại logic nghiệp vụ trên nhiều màn hình khác nhau.  
Dễ thay thế nguồn dữ liệu (nâng cấp database, thay đổi ORM) mà không ảnh hưởng UI.

- Kiến trúc phân tầng nội bộ

Cả ứng dụng được tổ chức theo quy trình:

Form (UI) → Service (BLL) → Repository (DAL) → DbContext (`BusManagement`) → Database.  

Form: xử lý sự kiện người dùng, thu thập input (chọn tuyến, lịch, ghế…), hiển thị kết quả.  
Service: kiểm tra dữ liệu hợp lệ, chứa logic nghiệp vụ (ví dụ: không cho đặt ghế đã có người, tính doanh thu theo khoảng thời gian, map ID bến sang tên bến…).  
Repository: thực hiện truy vấn và cập nhật database thông qua Entity Framework và LINQ.  
Database: lưu trữ toàn bộ thông tin vận hành ga xe khách.

Thiết kế giúp mã nguồn rõ ràng, dễ test logic nghiệp vụ và hạn chế tình trạng logic bị “trộn” vào giao diện.

- Thiết kế dữ liệu

Các bảng chính:

Account, Admin, Staff: quản lý tài khoản và thông tin người dùng hệ thống.  
Station: thông tin bến xe.  
Route, Route_SubRoute: tuyến đường và các chặng cụ thể giữa các bến.  
Bus: thông tin xe khách.  
SEAT: danh sách ghế theo từng xe.  
Schedule, Schedule_Stop: lịch chạy và các điểm dừng theo từng chuyến.  
Ticket: vé xe gắn với lịch chạy, ghế, trạm đi/trạm đến, giá vé, ngày đặt.  
Bus_Location_History: lịch sử vị trí xe theo thời gian (phục vụ theo dõi vận hành và báo cáo).  

Một số quan hệ chính:

1 Station → N Route (bến bắt đầu / bến kết thúc tuyến).  
1 Route → N Schedule (mỗi tuyến có nhiều lịch chạy theo ngày/giờ).  
1 Schedule → N Schedule_Stop (một chuyến có nhiều điểm dừng).  
1 Bus → N Schedule (một xe có thể chạy nhiều chuyến).  
1 Schedule + 1 SEAT → N Ticket (vé gắn với chuyến cụ thể và ghế cụ thể).  
1 Account → 1 Admin hoặc 1 Staff (liên kết account với vai trò người dùng).  

Cấu trúc dữ liệu hỗ trợ:

Tra cứu trạng thái ghế theo từng chuyến.  
Quản lý lịch chạy theo tuyến, theo ngày.  
Theo dõi lịch sử đặt vé, lịch sử di chuyển xe.  
Thống kê doanh thu theo ngày/tháng/năm và theo tuyến.

- Công nghệ sử dụng

Ngôn ngữ & nền tảng

C#  
.NET Framework 4.7.2  
Windows Forms

Data & ORM

SQL Server  
Entity Framework 6 (Database-First)  
LINQ to Entities

Thư viện & UI

Guna.UI2 (UI framework cho WinForms, giao diện hiện đại).  
LiveCharts / OxyPlot / ScottPlot (vẽ biểu đồ và dashboard doanh thu).  
System.Windows.Forms.DataVisualization (biểu đồ mặc định của .NET).  

- Ví dụ luồng xử lý

Nhân viên đăng nhập hệ thống bằng tài khoản Staff.  
Chọn chức năng “Đặt vé”: hệ thống hiển thị danh sách tuyến, lịch chạy và trạng thái ghế.  
Nhân viên chọn bến đi, bến đến, ngày giờ, chuyến xe, ghế còn trống.  
Service kiểm tra trạng thái ghế, tính giá vé, tạo `Ticket` và lưu xuống database, đồng thời cập nhật trạng thái ghế sang “đã đặt”.  
Nhân viên có thể xem chi tiết vé, in hoặc cung cấp mã vé cho khách hàng.  

Trong trường hợp khách muốn hủy vé:

Nhân viên tìm vé theo mã hoặc thông tin khách.  
Chọn chức năng “Hủy vé”: Service cập nhật trạng thái vé, giải phóng ghế tương ứng trong bảng `SEAT`/`Ticket`.  

Với admin:

Đăng nhập bằng tài khoản Admin.  
Quản lý tuyến, lịch chạy, cấu hình xe và số ghế.  
Mở màn hình doanh thu ngày/tháng/năm: hệ thống dùng `TicketService` truy vấn dữ liệu thu tiền theo thời gian, vẽ biểu đồ bằng LiveCharts/OxyPlot/ScottPlot để hỗ trợ phân tích.

- Kiến thức & kỹ năng áp dụng

Thiết kế ứng dụng desktop theo kiến trúc phân tầng (UI – BLL – DAL – DTO).  
Xây dựng Repository Pattern và sử dụng Entity Framework 6 với SQL Server.  
Sử dụng LINQ để truy vấn, tổng hợp doanh thu, thống kê theo thời gian.  
Thiết kế và triển khai mô hình dữ liệu quan hệ cho hệ thống quản lý ga xe khách.  
Xây dựng UI WinForms hiện đại với Guna.UI2, tối ưu cho nhân viên sử dụng hằng ngày.  
Tạo các màn hình thống kê và biểu đồ doanh thu với LiveCharts/OxyPlot/ScottPlot.  
Xử lý nghiệp vụ đặc thù: đặt/hủy vé, quản lý lịch chạy, trạng thái ghế, phân quyền người dùng.  
Tổ chức mã nguồn rõ ràng, có thể mở rộng (thêm tính năng quản lý khách hàng, thanh toán online, v.v. trong tương lai).
