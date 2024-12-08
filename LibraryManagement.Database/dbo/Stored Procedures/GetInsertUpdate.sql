create proc GetInsertUpdate
@flag int = 0,
@offset int = 0,
@fetch int = 0,
@Book_id int = 0,
@Author  NVARCHAR(150) = '',
@Title nvarchar(150) = '',
@Genre nvarchar(150) = '',
@CopiesAvailable int = 0
as
begin
	if(@flag = 1)
	begin
		select * from Books where IsDeleted = 0;
		
	end

	else if (@flag = 2)
	begin
		select * from Books where IsDeleted = 0 order by Book_id Offset @offset rows fetch next @fetch rows only;
	end
	else if(@flag = 3)
	begin
		select * from Books where Book_id = @Book_id and IsDeleted = 0
	end
	else  if(@flag = 4)
	begin
			insert into Books(Author,Title,Genre,CopiesAvailable) values(@Author,@Title,@Genre,@CopiesAvailable)
	end
	else if(@flag = 5)
	begin
		update Books 
		set Author = @Author,Title=@Title,Genre=@Genre,CopiesAvailable=@CopiesAvailable where Book_id = @Book_id
	end
	else if(@flag = 6)
		update Books
		set IsDeleted = 1 where Book_id = @Book_id
end
