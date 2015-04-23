using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables;

namespace DatabaseHelper
{
    public class DBHelper
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.15.0;Data Source=C:\Users\alexf_000\Dropbox\Навчання\ІІІ рік\VS2012Proj\Login_logout\Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public DBHelper()
        {
            ConnectTo();
        }

        public List<User> getUsers()
        {
            List<User> personsList = new List<User>();

            try
            {
                command.CommandText = "SELECT * FROM Users";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    User s = new User();
                    //s.Id = Convert.ToInt32(reader["user_id"].ToString());
                    s.Login = reader["Login"].ToString();
                    s.Password = reader["Password"].ToString();
                    s.Type = reader["Type"].ToString();

                    personsList.Add(s);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public void AddMovie(Movie m)
        {
            try
            {

                command.CommandText = "INSERT INTO Movie ([Title], [Year], [Duration], [KinoPoisk], [IMDB], [Metacritic], [RottenTomatoes], [Age_rating]) VALUES('" + 
                    m.Title + "', '" + 
                    m.Year + "','" + 
                    m.Duration + "','" +
                    m.KinoPoisk + "','" +
                    m.Imdb + "','" +
                    m.Metacritic + "','" +
                    m.RottentTomatoes + "','" +
                    m.Age +
                    "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }


        }

        public List<Movie> getMovies()
        {
            List<Movie> personsList = new List<Movie>();

            try
            {
                command.CommandText = "SELECT * FROM Movie";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Movie m = new Movie();
                    m.Id = Convert.ToInt32(reader["movie_id"].ToString());
                    m.Title = reader["Title"].ToString();
                    m.Year = Convert.ToInt32(reader["Year"].ToString());
                    m.Duration = Convert.ToInt32(reader["Duration"].ToString());
                    m.KinoPoisk = Convert.ToDouble(reader["KinoPoisk"].ToString());
                    m.Imdb = Convert.ToDouble(reader["IMDB"].ToString());
                    m.Metacritic = Convert.ToDouble(reader["Metacritic"].ToString());
                    m.RottentTomatoes = Convert.ToDouble(reader["RottenTomatoes"].ToString());
                    m.Age = Convert.ToInt32(reader["Age_rating"].ToString());

                    personsList.Add(m);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Country> getCountries()
        {
            List<Country> personsList = new List<Country>();

            try
            {
                command.CommandText = "SELECT * FROM Countries";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Country c = new Country();
                    c.Country_name1 = reader["Country_name"].ToString();


                    personsList.Add(c);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Genre> getGenres()
        {
            List<Genre> personsList = new List<Genre>();

            try
            {
                command.CommandText = "SELECT * FROM Genres";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Genre g = new Genre();
                    g.GenreName = reader["Genre_name"].ToString();


                    personsList.Add(g);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void AddMovieCountry(Movie m, Country c)
        {
            try
            {

                command.CommandText = "INSERT INTO Movie_and_country ([id_movie], [Country_name]) VALUES('" + m.Id + "', '" + c.Country_name1 +  "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Country> getCountriesByMovie(Movie m)
        {
            List<Country> personsList = new List<Country>();

            try
            {
                command.CommandText = "SELECT Country_name FROM Movie_and_country WHERE id_movie = " + m.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Country c = new Country();
                    c.Country_name1 = reader["Country_name"].ToString();

                    personsList.Add(c);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteMovie(Movie m)
        {
            try
            {
                command.CommandText = "DELETE FROM Movie WHERE movie_id=" + m.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void AddMovieGenre(Movie m, Genre g)
        {
            try
            {

                command.CommandText = "INSERT INTO Movie_and_genre ([id_movie], [Genre_name]) VALUES('" + m.Id + "', '" + g.GenreName + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Genre> getGenresByMovie(Movie m)
        {
            List<Genre> personsList = new List<Genre>();

            try
            {
                command.CommandText = "SELECT Genre_name FROM Movie_and_genre WHERE id_movie = " + m.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Genre g = new Genre();
                    g.GenreName = reader["Genre_name"].ToString();

                    personsList.Add(g);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Studio> getStudios()
        {
            List<Studio> personsList = new List<Studio>();

            try
            {
                command.CommandText = "SELECT * FROM Studios";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Studio s = new Studio();
                    s.StudioName = reader["Studio_name"].ToString();

                    personsList.Add(s);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void AddMovieStudio(Movie m, Studio s)
        {
            try
            {

                command.CommandText = "INSERT INTO Movie_and_studio ([id_movie], [Studio_name]) VALUES('" + m.Id + "', '" + s.StudioName + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Studio> getStudiosByMovie(Movie m)
        {
            List<Studio> personsList = new List<Studio>();

            try
            {
                command.CommandText = "SELECT Studio_name FROM Movie_and_studio WHERE id_movie = " + m.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Studio s = new Studio();
                    s.StudioName = reader["Studio_name"].ToString();

                    personsList.Add(s);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void UpdateMovie(Movie oldMovie, Movie newMovie)
        {
            try
            {

                command.CommandText = "UPDATE Movie SET " +
                    "[Title] = '" + newMovie.Title + "', " +
                    "[Year] = '" + newMovie.Year + "', " +
                    "[Duration] = '" + newMovie.Duration + "', " +
                    "[KinoPoisk] = '" + newMovie.KinoPoisk + "', " +
                    "[IMDB] = '" + newMovie.Imdb + "', " +
                    "[Metacritic] = '" + newMovie.Metacritic + "', " +
                    "[RottenTomatoes] = '" + newMovie.RottentTomatoes + "', " +
                    "[Age_rating] = '" + newMovie.Age + "' WHERE movie_id = " + oldMovie.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }



        /*************************/
        public void DeleteMovieCountry(Movie m)
        {
            try
            {
                command.CommandText = "DELETE FROM Movie_and_country WHERE id_movie=" + m.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteMovieGenre(Movie m)
        {
            try
            {
                command.CommandText = "DELETE FROM Movie_and_genre WHERE id_movie=" + m.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteMovieStudio(Movie m)
        {
            try
            {
                command.CommandText = "DELETE FROM Movie_and_studio WHERE id_movie=" + m.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        /****************************/


        /**************************/
        public void AddCountry(Country c)
        {
            try
            {
                command.CommandText = "INSERT INTO Countries (Country_name) VALUES('" + c.Country_name1 + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void AddGenre(Genre g)
        {
            try
            {
                command.CommandText = "INSERT INTO Genres (Genre_name) VALUES('" + g.GenreName + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void AddStudio(Studio s)
        {
            try
            {
                command.CommandText = "INSERT INTO Studios (Studio_name) VALUES('" + s.StudioName + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        /******************************/


        /******************************/
        public void DeleteCountry(Country c)
        {
            try
            {
                command.CommandText = "DELETE FROM Countries WHERE Country_name='" + c.Country_name1 + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteGenre(Genre g)
        {
            try
            {
                command.CommandText = "DELETE FROM Genres WHERE Genre_name='" + g.GenreName + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteStudio(Studio s)
        {
            try
            {
                command.CommandText = "DELETE FROM Studios WHERE Studio_name='" + s.StudioName + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        /*******************************/


        /********************************/

        public void AddUserMovie(Movie m, User u, int rate)
        {
            try
            {

                command.CommandText = "INSERT INTO User_and_movie ([id_movie], [user_login], [Rating]) VALUES('" + m.Id + "', '" + u.Login + "', '" + rate + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void AddUserStar(Star s, User u)
        {
            try
            {

                command.CommandText = "INSERT INTO User_and_star ([id_star], [user_login]) VALUES('" + s.Id + "', '" + u.Login + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        public int getUserRating(Movie m, User user)
        {
            int result = 0;

            try
            {
                command.CommandText = "SELECT [Rating] FROM User_and_movie WHERE [id_movie] = " + m.Id + " AND [user_login] = '" + user.Login + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //Genre g = new Genre();
                    result = Convert.ToInt32(reader["Rating"].ToString());

                    //personsList.Add(g);
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteUserMovie(Movie m, User user)
        {
            try
            {
                command.CommandText = "DELETE FROM User_and_movie WHERE id_movie=" + m.Id + " AND [user_login] = '" + user.Login + "'" ;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public double getAvRatingForMovie(Movie m)
        {
            double result = 0;

            try
            {
                command.CommandText = "SELECT avg(Rating) as Average FROM User_and_movie WHERE [id_movie] = " + m.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
  
                    result = Convert.ToDouble(reader["Average"].ToString());
                   

                    

                    //personsList.Add(g);
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public int CountRatingsForMovie(Movie m)
        {
            int result = 0;

            try
            {
                command.CommandText = "SELECT COUNT(Rating) as Lol FROM User_and_movie WHERE [id_movie] = " + m.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    result = Convert.ToInt32(reader["Lol"].ToString());

                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Movie> getMoviesByUser(User u)
        {
            List<Movie> personsList = new List<Movie>();

            try
            {
                command.CommandText = "SELECT movie_id, Title, Year FROM User_and_movie, Movie WHERE [id_movie] = [movie_id] AND [user_login] = '" + u.Login + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Movie m = new Movie();
                    m.Id = Convert.ToInt32(reader["movie_id"].ToString());
                    m.Title = reader["Title"].ToString();
                    m.Year = Convert.ToInt32(reader["Year"].ToString());
                   
                    personsList.Add(m);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        /**********************************/



        /*************************************/
        public void AddStar(Star s)
        {
            try
            {

                command.CommandText = "INSERT INTO Star ([Name], [Second_name], [Birthday], [Career_date], [Born_place]) VALUES('" +
                    s.Name + "', '" +
                    s.SecondName + "','" +
                    s.Birthday + "','" +
                    s.CareerDate + "','" +
                    s.BornPlace + 
                    "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Star> getStars()
        {
            List<Star> personsList = new List<Star>();

            try
            {
                command.CommandText = "SELECT * FROM Star";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Star s = new Star();
                    s.Id = Convert.ToInt32(reader["star_id"].ToString());
                    s.Name = reader["Name"].ToString();
                    s.SecondName = reader["Second_name"].ToString();
                    s.Birthday = reader["Birthday"].ToString();
                    s.CareerDate = Convert.ToInt32(reader["Career_date"].ToString());
                    s.BornPlace = reader["Born_place"].ToString();

                    personsList.Add(s);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteStar(Star s)
        {
            try
            {
                command.CommandText = "DELETE FROM Star WHERE star_id=" + s.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void UpdateStar(Star star, Star newStar)
        {
            try
            {

                command.CommandText = "UPDATE Star SET " +
                    "[Name] = '" + newStar.Name + "', " +
                    "[Second_name] = '" + newStar.SecondName + "', " +
                    "[Birthday] = '" + newStar.Birthday + "', " +
                    "[Career_date] = '" + newStar.CareerDate + "', " +
                    "[Born_place] = '" + newStar.BornPlace + "' WHERE star_id = " + star.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void AddParticularMovie(Movie m, Star s, string p)
        {
            try
            {

                command.CommandText = "INSERT INTO Particular_movie ([id_movie], [id_star], [Type_of_star]) VALUES('" + m.Id + "', '" + s.Id + "', '" + p + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Movie> getStarMovies(Star star)
        {
            List<Movie> personsList = new List<Movie>();

            try
            {
                command.CommandText = "SELECT movie_id, Title, Year FROM Particular_movie, Movie WHERE [id_movie] = [movie_id] AND [id_star] = " + star.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Movie m = new Movie();
                    m.Id = Convert.ToInt32(reader["movie_id"].ToString());
                    m.Title = reader["Title"].ToString();
                    m.Year = Convert.ToInt32(reader["Year"].ToString());

                    if(!Exists(personsList, m))
                        personsList.Add(m);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        private Boolean Exists(List<Movie> movies, Movie m)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                if (m.Id == movies.ToArray()[i].Id)
                    return true;
            }

            return false;
        }

        public List<Star> getStarWithRole(Movie m, string p)
        {
            List<Star> personsList = new List<Star>();

            try
            {
                command.CommandText = "SELECT star_id, Name, Second_name, Career_date, Birthday, Born_place FROM Particular_movie, Star WHERE [id_star] = [star_id] AND [id_movie] = " + m.Id +  " AND [Type_of_star] = '" + p + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Star s = new Star();
                    s.Id = Convert.ToInt32(reader["star_id"].ToString());
                    s.Name = reader["Name"].ToString();
                    s.SecondName = reader["Second_name"].ToString();
                    s.CareerDate = Convert.ToInt32(reader["Career_date"].ToString());
                    s.Birthday = reader["Birthday"].ToString();
                    s.BornPlace = reader["Born_place"].ToString();

                    personsList.Add(s);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        /*******************************/












        public List<Star> getStarsByUser(User user)
        {
            List<Star> personsList = new List<Star>();

            try
            {
                command.CommandText = "SELECT star_id, Name, Second_name, Career_date, Birthday, Born_place FROM User_and_star, Star WHERE [id_star] = [star_id] AND [user_login] = '" + user.Login + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Star s = new Star();
                    s.Id = Convert.ToInt32(reader["star_id"].ToString());
                    s.Name = reader["Name"].ToString();
                    s.SecondName = reader["Second_name"].ToString();
                    s.CareerDate = Convert.ToInt32(reader["Career_date"].ToString());
                    s.Birthday = reader["Birthday"].ToString();
                    s.BornPlace = reader["Born_place"].ToString();

                    personsList.Add(s);
                }

                return personsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void AddUser(User u)
        {
            try
            {
                command.CommandText = "INSERT INTO Users ([Login], [Password], [Type]) VALUES('" 
                    + u.Login + "'," 
                    + "'" + u.Password + "',"
                    + "'" + u.Type + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteUser(User u)
        {
            try
            {
                command.CommandText = "DELETE FROM Users WHERE Login= '" + u.Login + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void ChangePassword(User user, string p)
        {
            try
            {
                command.CommandText = "UPDATE Users SET [Password]= '" + p + "' WHERE [Login]= '" + user.Login + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteStarFromMovie(Movie m, Star s, string type)
        {
            try
            {
                command.CommandText = "DELETE FROM Particular_movie WHERE id_movie=" + m.Id + " AND id_star=" + s.Id + " AND [Type_of_star]= '" + type + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
