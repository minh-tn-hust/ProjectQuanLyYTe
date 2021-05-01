

# Cài đặt
  Muốn giao tiếp được với Database thông qua Controller, đầu tiên clone về, sau đó vào Project đang làm thêm 2 Project Controller và YTeDb vào, rồi liên kết chúng với Project đang làm
## Cách liên kết 2 cái trên vào project Testing
  ![image](https://user-images.githubusercontent.com/58616490/116721006-07f63100-aa07-11eb-9f4d-1f6919da9b80.png)\
 Chuột phải chọn Add -> Reference:
  ![image](https://user-images.githubusercontent.com/58616490/116721207-40960a80-aa07-11eb-84f0-f042f213b98a.png)\
 Tích chọn Controller (mình sẽ sử dụng các hàm trong controller để có thể load và chỉnh sửa được cơ sở dữ liệu)
  ![image](https://user-images.githubusercontent.com/58616490/116721362-6a4f3180-aa07-11eb-936a-120d76b02d1d.png)\
 **Nhớ cài framework EF6 cho project hiện tại và controller**\
 **Copy file App.config trong YTeDb vào trong Project hiện tại**

# Giải thích một các class có trong Controller
  *Các hàm trong Controller sẽ được gọi thông qua các đối tượng*
  ** LoadingTable (sử dụng để có thể Load dữ liệu nhanh cho DataGridView **
  ```Csharp
  LoadingTable loadTable = new LoadingTable();
  dataGridView1.DataSource = loadTable.nhanhvien(); //Load dữ liệu từ bảng nhân viên cho dataGridView1
  dataGridView1.DataSource = loadTable.treem(); //Load dữ liệu từ bảng trẻ em cho dataGridView1
  dataGridView1.DataSource = loadTable.phunumangthai(); //Load dữ liệu từ bảng phụ nữ mang thai cho dataGridView1
  dataGridView1.DataSource = loadTable.vacxin(); //Load dữ liệu từ bảng vắc xin cho dataGridView1
  ```
  ** DTGFilter (sử dụng để có thể lọc được dữ liệu thông qua DataGridView + Tên cột + Dữ liệu cần tìm **
  ```Csharp
  DTGFilter filter = DTGFilter();
  dataGridView1.DataSource = filter.searchRow(dataGridView1, "Số CMND", textBox1.Text) // load lại DataGridView với những dòng mà có dữ liệu trùng với textBox1.Text ở cột "Số CMND"
  ```
