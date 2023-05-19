using System.Data.Entity;
using AutoMapper;
using WebApplication2.Data;
using WebApplication2.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Repository;

public class ReviewerRepository: IReviewerRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public ReviewerRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public ICollection<Reviewer> GetReviewers()
    {
        return _context.Reviewers.ToList();
    }

    public Reviewer GetReviewer(int reviewerId)
    {
        return _context.Reviewers.Where(r => r.Id == reviewerId)
            .Include(e => e.Reviews).FirstOrDefault();
    }

    public ICollection<Review> GetReviewsByReviewer(int reviewerId)
    {
        return _context.Reviews.Where(r => r.Reviewer.Id == reviewerId).ToList();
    }

    public bool ReviewerExists(int reviewerId)
    {
        return _context.Reviewers.Any(r => r.Id == reviewerId);
    }

    public bool CreateReviewer(Reviewer reviewer)
    {
        _context.Add(reviewer);
        return Save();
    }

    public bool UpdateReviewer(Reviewer reviewer)
    {
        _context.Update(reviewer);
        return Save();
    }

    public bool DeleteReviewer(Reviewer reviewer)
    {
        _context.Remove(reviewer);
        return Save();
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}