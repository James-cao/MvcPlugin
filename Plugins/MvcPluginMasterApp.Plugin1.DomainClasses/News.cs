﻿using System.Data.Entity.ModelConfiguration;

namespace MvcPluginMasterApp.Plugin1.DomainClasses
{
    public class News
    {
        public int Id { set; get; }

        public string Title { set; get; }

        public string Body { set; get; }
    }

    public class NewsConfig : EntityTypeConfiguration<News>
    {
        public NewsConfig()
        {
            this.ToTable("Plugin1_News");
            this.HasKey(news => news.Id);
            this.Property(news => news.Title).IsRequired().HasMaxLength(500);
            this.Property(news => news.Body).IsOptional().IsMaxLength();
        }
    }
}