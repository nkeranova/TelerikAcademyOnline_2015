﻿using System;

public class ExamResult
{
    private int grade;

    private int minGrade;

    private int maxGrade;

    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    /// <exception cref="ArgumentOutOfRangeException" accessor="set">Grade cannot be negative</exception>
    public int Grade
    {
        get
        {
            return this.grade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade cannot be negative");
            }

            this.grade = value;
        }
    }

    /// <exception cref="ArgumentOutOfRangeException" accessor="set">MinGrade cannot be negative</exception>
    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("MinGrade cannot be negative");
            }

            this.minGrade = value;
        }
    }

    /// <exception cref="ArgumentOutOfRangeException" accessor="set">MaxGrade should be greater than MinGrade</exception>
    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            if (value <= this.MinGrade)
            {
                throw new ArgumentOutOfRangeException("MaxGrade should be greater than MinGrade");
            }

            this.maxGrade = value;
        }
    }

    /// <exception cref="ArgumentException" accessor="set">Comments cannot be null or empty</exception>
    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Comments cannot be null or empty");
            }

            this.comments = value;
        }
    }
}