Trình bày các task cần làm đối với hệ thông, phân tích sơ bộ
============================================================

Phân tích sơ bộ
---------------

> Với những yêu cầu đặt ra từ phía khách hàng, chúng tôi nhận định được
> các đối tượng sẽ trực tiếp tham gia vào hệ thống như sau
>
> 1.  **Cư dân Ecopark:** Đây là nhóm đối tượng chủ yếu mà hệ thống sẽ
>     phục vụ. Với số lượng cư dân lớn cùng với như cầu sử dụng xe đạp
>     trong khuôn viên Ecopark tăng cao, hệ thống phải đảm bảo được các
>     dịch vụ cơ bản dành cho nhóm đối tượng này. Bên cạnh đó phải tối
>     ưu quá trình tự động hóa thuê xe đạp để có thể đem lại cho người
>     dùng trải nghiệm tốt nhất, không làm mất đi thương hiệu của
>     Ecopark. Đối với đối tượng này, để phù hợp với nhu cầu di chuyển
>     cũng như việc truy cập vào hệ thống, bên chúng tôi cung cấp một
>     ứng dụng di động để có thể đặt thuê và làm một vài thủ tục tiên
>     quan trên đấy, nhằm giảm thời gian chờ đợ thủ tụi cũng như di
>     chuyển của người dùng. Ứng dụng chạy trên đa nền tảng để có thể
>     phủ sóng tới tất cả cư dân.
>
> 2.  **Người quản lý bốt và bốt xe:** Đây là nhóm đối tượng sẽ đảm bảo
>     việc duy trì và kiểm soát bãi tập kết xe cũng như là đón tiếp
>     người dùng. Nhiệm vụ cơ bản của nhóm đối tượng này là hỗ trợ khách
>     hàng từ việc lấy xe tới bảo quản và kiểm tra xe .Với mỗi người
>     quản lý sẽ được cấp tài khoản để sử dụng web quản lý tương ứng với
>     mỗi bốt xe, nhằm quản lý lượng xe vào ra và có thể cập nhật lại
>     trạng thái của xe mỗi khi có người trả xe. Đối với mỗi bốt xe đều
>     có máy tính để có thể thực hiện việc truy cập vào hệ thống. Người
>     dùng sẽ tương tác với bốt để thêu hoặc trả xe bằng việc quét mã QR
>     có sẵn tại từng bốt. Mỗi khi quét sẽ xuât hiện thông báo lên máy
>     tính của nhân viên quản lý bốt để nhân viên có thể thực hiện phần
>     việc của mình
>
> 3.  **Nhân viên lễ tân:** Đây là nhóm đối tượng cung cấp các dịch vụ
>     như nạp tiền vào tài khoản cho cư dân, tạo và xác nhận thông tin
>     tài khoản cho cư dân. Với việc mỗi toàn Ecopark đều có một quầy lễ
>     tân, hệ thống sẽ tích hợp lên các máy tính có sẵn tại các tòa lễ
>     tân để người dùng có thể tiện đăng kí cũng như nạp tiền vào tài
>     khoản thuê xe
>
> 4.  **Nhân viên quản lý:** Là đối tượng có quyền cao nhất trong hệ
>     thống, và không tương tác với khách hàng mà chỉ tương tác với các
>     nhân viên của Ecopark có trong hệ thống. Có thể hiểu đây là
>     Adminstrator có tất cả các quyền về hệ thống,có quyền thống kê,
>     thêm sửa xóa bất kì dữ liệu nào trong hệ thống.
>
> **Yêu cầu đối với hệ thống:** Hệ thống phải đảm bảo được tính ổn định
> và khả năng nâng cấp cao. Bên cạnh đó là yếu tố chạy đua cùng với thời
> gian. Các công nghệ mà hệ thống lựa chọn cho hệt thống phải đảm bảo
> được những yêu cầu cũng như lượng truy cập, hạn chế xảy ra tắc nghẽn
> để đảm bảo cho những người tham gia vào hệ thống một trải nghiệm mượt
> mà nhất. Khả năng bảo trì và nâng cấp cũng rất quan trọng đối với hệ
> thống, vì vậy việc phát triển hệ thống dưới dạng module luôn được ưu
> tiên hàng đầu, hệ thống chính sẽ là tổ hợp của các module nhỏ lại với
> nhau, sau này khi tiến hành nâng cấp , sửa chữa thay thếp module nào
> đó sẽ không làm ảnh hưởng tới cả hệ thống. Việc hệ thống được phát
> triển như thế nào cần được phân tích và định hướng sớm để có thể đưa
> ra được kết hoạch phù hợp trong quá phát triển sản phẩm.

Trình bày các task cần làm đối với hệ thống
-------------------------------------------

### Chức năng thuê xe, trả xe của người dùng

-   *Tìm kiếm xe phù hợp ( xem trạng thái xe, mẫu mã xe, ...):* cung cấp
    các tính năng lựa chọn loại xe, lựa chọn màu cũng như thời gian lấy
    và trả xe phù hợp với nhu cầu của mỗi cá nhân sử dụng dịch vụ.

-   * Lựa chọn xe( đóng gói thông tin, tạo mã QR):* Cung cấp cho khách
    hàng (cư dân Ecopark) quá trình lấy và trả xe tự động và đảm bảo
    được tính bảo mtậ thông qua mã QR code. Bên cạnh đó hỗ trợ cho các
    bốt xe có thể quản lý xe một cách dễ dàng hơn, không rườm rà nhiều
    thiết bị, dây nhợ.

-   *Quá trình thuê xe, trả xe*

    -   *Feedback về sản phẩm:* ghi nhận và cải thiện những thiếu sót mà
        hệ thống còn mắc phải nhằm đem lại cho khách hàng sự thoải mái
        nhất

    -   *Trả tiền thuê xe:* cung cấp quá trình trao đổi nhanh chóng,
        tiện lợi thông qua việc trừ tiền trực tiếp trong tài khoản. Hóa
        đơn điện tử ngay lập tức được gửi tới tài khoản của khách hàng
        nhằm đảm bảo tính minh bạch.

    -   *Tiền đặt cọc:* một phần phí đảm bảo được giữ lại trong tài
        khoản của khách hàng nhằm hỗ trợ khách hàng trong quá trình thuê
        và sử dụng xe phát sinh ra. Không yêu cầu tiền mặt vì đã có tiền
        trong tài khoản để có thể duy trì khoản phí này

### Quản lý xe, bãi giữ xe

Các tính năng cũng như nhiệm vụ dành cho các quản lý bãi xe để đảm bảo
được hệ thống hoạt động suôn sẻ bao gồm:

-   *Thêm bãi giữ xe, chỉnh sửa thông tin liên quan đến bãi xe*

-   *Thêm xe, chỉnh sửa các thông tin liên quan đến xe, xóa thông tin*

-   *Cập nhật thông tin của xe*

-   *Cập nhật trại thái xe*

Những công việc trên yêu cầu quản lỹ bốt xe truy cập vào hệ thống để
tiến hành chỉnh sửa dữ liệu, nên phải giới hạn các quyền về truy cập
nhằm tránh những trường hợp không đáng có xảy ra. Việc cấp quyền truy
cập này sẽ do Adminstrator quản lý.

### Quản lý các vấn đề về các loại tài khoản

-   Tài khoản người dùng:

    -   *Tính năng đăng nhập, đăng kí:*

        > Cung cấp phương thức đăng kí tiện lợi cho người dùng. Nhanh
        > gọn nhẹ tại các quầy lễ tân, cũng như nạp tiền được quy về vị
        > trí lễ tân, thuận tiện cho việc đi lại của người dùng. Vì tính
        > năng này cần sự minh bạch nên sẽ có sự can thiệp của bên lễ
        > tân. Dự định sẽ phát triển thêm tính năng thanh toán qua ví
        > điện tử để người dùng có thể kiểm soát được tốt hơn.

    -   *Thuê xe:* Quá trình thuê xe diễn ra nhanh chóng diễn ra trong 5
        bước.

        > 1.  Lựa chọn xe mình thích
        >
        > 2.  Lựa chọn bốt xe muốn lấy
        >
        > 3.  Quét mã để xác nhận thuê
        >
        > 4.  Sử dụng
        >
        > 5.  Quét mã để xác nhận thanh toán
        >
        Quy trình được tự động hóa hoàn toàn đem lại sự nhanh chóng và
        thuận tiện cho người dùng sử dụng

    -   *Xem lịch sử thuê xe (bill):*

        > Nhằm đảm bảo sự rõ ràng, minh bạch về tài khoản của người
        > dùng, bất cứ thao tác nào liên quan tới tài chính của người
        > dùng sẽ được xuất ra hóa đơn điện tử gửi về tài khoản của
        > khách hàng ngay lập tức

    -   *Chỉnh sửa một số thông tin cơ bảnbản của người dùng*

-   Tài khoản lễ tân

    -   *Đăng nhập:*

        > Để có thể đăng nhập được vào hệ thống dưới vai trò lễ tân,
        > nhân viên lễ tân sẽ được quản lý cấp cho một tài khoản để có
        > thể tương tác với hệ thống

    -   *Xác thực tài khoản người dùng: *

        > Xác thực người dùng để nhanh chóng tạo tài khoản. Với việc sử
        > dụng thẻ cư dân, việc truy xuất thông tin đối với lễ tân chưa
        > bao giờ là khó.

    -   *Tạo tài khoản mới cho người dùng:*

        > Mỗi khi người dùng muốn đăng kí sử dụng dịch vụ, tới gặp lễ
        > tân ở toàn nhà mà mình đang sống để có thể tiến hành tạo tài
        > khoản thuê xe

    -   *Nạp tiền vào tài khoản người dùng:*

        > Hiện tại chưa hỗ trợ nạp tiền thông qua các ví điện tử, việc
        > nạp tiền cần phải xác nhận được thông tin của người dùng. Vì
        > vậy đây là tính năng mà những nhân viên lễ tân phải đảm nhận.
        > Hệ thống sẽ đảm bảo rằng quá trình này diễn ra một cách rõ
        > ràng, không mập mà trước người dùng bằng việc gửi hóa đơn xác
        > nhận thanh toán về cho người dùng tại App để người dùng xác
        > nhận

    -   * Chỉnh sửa thông tin quan trọng trong tài khoản người dùng:*

        > Những thông tin mà người dùng cần phải được xác thực mới được
        > chỉnh sửa. Ví dụ như điều chỉnh mã cư dân trên tài khoản...

    -   *Lọc thông tin người dùng*

    -   *Thống kê lượng tiền thu vào*

-   Tài khoản nhân viên quản lý từng bãi xe

    -   *Đăng nhập*

        > Cũng giống như lễ tân, nhân viên quản lý được Adminstrator
        > cung cấp tài khoản để có thể truy cập vào hệ thống, chịu sự
        > quản lý của Adminstrator

    -   *Cập nhật trạng thái của xe:*

        > Sau khi khách hàng sử dụng xe và tiến hành trả xe, nhân viên
        > quản lý sẽ thực hiện kiểm tra xe để có thể xác nhận khách trả
        > xe thành công. Mỗi khi khách hàng quét mã QR để có thể trả xe,
        > hệ thống sẽ gửi thống báo tới máy của nhân viên quản lý để có
        > thể cập nhật lại trạng thái của xe sau khi đã được khách hàng
        > sử dụng. Nếu có vấn đề phát sinh trong quá trình trả xe, nhân
        > viên sẽ feedback lại trong thống báo, bên kĩ thuật sẽ kiểm tra
        > và xác nhận, trừ tiền khách hàng.

    -   *Lấy danh sách xe trong khu chứa, thông tin của xe*

        > Lấy và thống kê được những xe hiện tại đang được sử dụng trong
        > hệ thống để có thể tiến hành kiểm tra và cập nhật lại hệ thống

    -   *Thống kê lượt thuê xe hay trả xe của khu quản lý*

-   Tài khoản người quản lý cao nhất Adminstrator có quyền cao nhất,
    thực hiện quản lý lễ tân, các bãi xe, nhân viên quản lý, hầu hết tất
    cả dữ liệu đều có thể truy cập và lấy được. Trừ những dữ liệu liên
    quan tới thông tin cá nhân của người dùng. Đây là đối tượng sẽ quản
    trị hệ thống. Các tính năng bao gồm:

    -   *Tạo tài khoản, chỉnh sửa thông tin nhân viên*

    -   *Quản lý các thông tin liên quan đến xe*

    -   *Quản lý thông tin liên quan đến các bãi giữ xe*

    -   *Quản lý quản lý thông tin thuê xe*

Tính khả quan của sản phẩm
==========================

Công nghệ sử dụng và rào cản về công nghệ
-----------------------------------------

### Công nghệ sử dụng

-   **Đối với ứng dụng mobile và web:** Sử dụng React - một
    cross-platform được phát triển bởi Facebook để có thể phát triển ứng
    dụng đa nền tàng nhanh nhất, tống ít nguồn lực để triển khai hơn.
    Với sự đồng bộ về cú pháp lập trình cũng như nền tảng phát triển thì
    React hỗ trợ mình phát triển app nhanh và tiện lợi hơn dễ dàng sử
    dụng hơn. Hiện nay cộng đồng hỗ trợ React rất lón có thể đảm bảo
    trong quá trình phát triển các lỗi gặp phải có khả năng giải quyết
    được. Nhưng bên cạnh đó cũng có sự phát sinh khi những bản build của
    React trên các thiết bị di động khá nặng và hiệu năng không cao. Đây
    là một điểm phải đánh đối khi sử dụng React để phát triển. Nhưng
    những lợi ích mà nó đêm lại để cung cấp một quá trình phát triển sản
    phẩm nhanh hơn là không thể bàn cãi.Với những dự án yều câu phát
    triển nhanh như thế này thì React là sự lựa chọn hàng đầu.

-   **Đối với server xử lý:** NodeJS là một nền tảng phát triển ứng dụng
    mạnh mẽ, Nodejs có thể thỏa mãn mọi nhu cầu lập trình, phát triển
    ứng dụng. Các chuyên gia trong lĩnh vực lập trình, công nghệ khuyên
    dùng Nodejs khi phát triển các ứng dụng như Websocket server, Fast
    File Upload Client, Ad Server, Cloud Services, RESTful API, Any
    Real-time Data Application,... Sử dụng Javascript để có thể đồng bộ
    với team làm client giúp cho việc cả team có thể hỗ trợ nhau trong
    quá trình phát triển. Đồng bộ giữa team Backend và Frontend giúp cho
    việc liên kết giữa hai phía trở nên tiện lợi và nhanh chóng hơn,
    giữa 2 bên cũng có tiếng nói chung. Đối với số lượng người truy cập
    dữ kiến thì khả năng hỗ trợ của NodeJS vẫn đủ để có thể đáp ứng nhu
    cầu hiện tại và trong tương lai nếu như muốn nâng cấp hệt thống. Bên
    cạnh sự tiền dụng mà NodeJS mang lại thì nhược điểm của nó là rất
    tốn tài nguyên phần cứng. Vì vậy cần phải cân đối để để phù hợp vói
    nhu cầu.

Nguồn lực triển khai
--------------------

-   ** Khả năng về công nghệ của các thành viên trong team** Các thành
    viên trong team đã được tiếp xúc và làm quen nhau một thời gian,
    hiểu rõ được điểu mạnh điểm yếu của nhau, trong các buổi training về
    công nghệ đầu tiên, khả năng tiếp thu công nghệ tuy có khác nhau
    nhưng nhờ sự gắn kết của team mà hầu như mọi người tham gia training
    đều có thể nắm được các yếu tố cơ bản về các công nghệ được ban
    chuyên môn đưa ra - những công nghệ chính được áp dụng vào dự án.
    Team hoàn toàn có thể đảm nhận được, có khả năng phát triển và duy
    trì dự án.

-   **Thời gian triển khai của dự án** Việc sử dụng phù hợp công nghệ
    mới để giảm thiểu thời gian phát triển dự án và tập trung vào các
    phần khác, các dịch vụ của ứng dụng được triển khai một cách nhanh
    chóng phù hợp với mô hình phát triển của dự án. Bên cạnh đó kết hợp
    với phân tích và thiết kế một cách có thể thống có thể tăng tốc được
    thời gian ra sản phẩm.Đảm bảo đúng tiến độ ban đầu team và khách
    hàng đã thỏa thuận.

-   **Kế hoạch và định hướng phát triển**: Sau khi trao đổi cùng phía
    khách hàng cũng như thắc mắc và hiểu các yêu cầu, team đã đặt ra 4
    cột mốc, mỗi cột mốc có một thành tựu riêng mà team phải đạt được.
    Tiếp đo, team đã tổ chức lên kế hoạch và phân công nhiệm vụ cụ thể
    cho từng thành viên trong từng giai đoạn, đúng với năng lực của mỗi
    thành viên cá nhân trong team. Mỗi cột mốc là một lần trao đổi với
    khách hàng, vì vậy sẽ là cơ hội tốt để team có thể trình bày tiến độ
    sản phẩm, nhận được các nhận xét và góp ý của khách hàng, làm cho
    sản phẩm được tốt hơn, thỏa mãn nhu cầu của khách hàng trước khi
    được ra mắt.

Phạm vi triển khai
------------------

Sau khi hoàn thiện dự án, sản phẩm cung cấp một thế thống hai ứng dụng,
ứng dụng cho quản lý tập trung trên nền tảng web và ứng dụng eBicycle
trên mobile cho người dùng sử dụng với các chức năng hạn chế chỉ dành
cho người dùng để thuê xe. Kết hợp với cơ sở hạ tầng hiện có để có thể
tạo nên được một hệ thống thuê xe đạp tự động hoàn chỉnh, phục vụ cho
các cư dân Ecopark. Một hệ thống minh bạch để khách hàng tin tưởng và sử
dụng. Hệ thống hoạt động tốt trong thời gian sử dụng và đảm bảo việc bảo
trì dễ dàng, không làm ảnh hưởng tới bất cứ đối tượng nào tham gia và hệ
thống, giảm thiểu được các thủ tục rườm ra mà hệ thống hiện tại đang còn
mắc phải
