   M S B A M L   `   `   `  ����  CodeGenerator    CodeGenerator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��800��6)   .��5      � .+�5   
   �� -   5         ��Name$ txtConnectionString��5      $
��Left=�6/   $��23��6J   $��
153,10,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $S��MData Source=.;Initial Catalog=EFDb;User ID=sa;Password=abc.12345;Pooling=true��6~   $	��Top=�6�   $	��617��6�   $��14(�6�   �� 5   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $!��数据库连接字符串：��6V   $	��Top=�6g   $	��138��6   $��24��6�   $��14(�6�   �� 5   
   -   5         ��Name$ btnLoadAllTable��5   ~   $��加载所有表��6   $
��Left=�6!   $��	10,39,0,0q�6<   $	��Top=�6O   $��95��6g   $��33��6r   6�   �� 5	   
   -   5        $ btnTestConnect��5	      $��测试连接��6   $
��Left=�6    $��
153,39,0,0q�6;   $	��Top=�6O   $	��112��6g   $��33��6s   6�   &   System.Windows.Controls.DataGrid  5
   
   -   5          Name$ dgTables��5
   r   $
��Left=�6   $��	10,97,0,0q�6.   $	��Top=�6A   $	��266��6Y   $	��395��6f      
IsReadOnly .    CanUserAddRows .  5      �� 5   
   -   5        $ btnCreateCode��5      $��生成代码��6   $
��Left=�6    $��
303,39,0,0q�6;   $	��Top=�6O   $	��102��6g   $��33��6s   6�   5      5      