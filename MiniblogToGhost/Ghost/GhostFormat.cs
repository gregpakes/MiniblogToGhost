using System.Collections.Generic;

namespace MiniblogToGhost.Ghost
{
    public class GhostFormat
    {
        public Meta meta { get; set; }
        public Data data { get; set; }
    }

    public class Meta
    {
        public long exported_on { get; set; }
        public string version { get; set; }
    }

    public class Data
    {
        public List<Post> posts { get; set; }
        public List<Tag> tags { get; set; }
        public List<Posts_Tags> posts_tags { get; set; }
        public List<User> users { get; set; }
        public List<Roles_Users> roles_users { get; set; }
    }

    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string slug { get; set; }
        public string markdown { get; set; }
        public string html { get; set; }
        public object image { get; set; }
        public int featured { get; set; }
        public int page { get; set; }
        public string status { get; set; }
        public string language { get; set; }
        public object meta_title { get; set; }
        public object meta_description { get; set; }
        public int author_id { get; set; }
        public long created_at { get; set; }
        public int created_by { get; set; }
        public long updated_at { get; set; }
        public int updated_by { get; set; }
        public long published_at { get; set; }
        public int published_by { get; set; }
    }

    public class Tag
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
    }

    public class Posts_Tags
    {
        public int tag_id { get; set; }
        public int post_id { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string email { get; set; }
        public object image { get; set; }
        public object cover { get; set; }
        public object bio { get; set; }
        public object website { get; set; }
        public object location { get; set; }
        public object accessibility { get; set; }
        public string status { get; set; }
        public string language { get; set; }
        public object meta_title { get; set; }
        public object meta_description { get; set; }
        public object last_login { get; set; }
        public long created_at { get; set; }
        public int created_by { get; set; }
        public long updated_at { get; set; }
        public int updated_by { get; set; }
    }

    public class Roles_Users
    {
        public int user_id { get; set; }
        public int role_id { get; set; }
    }
}